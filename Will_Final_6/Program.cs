using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace Will_Final_6
{
    internal class Program
    {
        public class Player
        {
            public string playerName;
            public int level;
            public int hp;
            public List<string> inventory;
            public string licenseKey;

            //Private constructor for the Player
            private Player()
            {

            }

            //Creates the instance of a Player
            private static Player instance = new Player();

            //Returns the instance of a Player
            public static Player GetInstance()
            {
                return instance;
            }

            //Open's the JSON formatted file and deserializes it
            public void OpenPlayerFile(string filename)
            {
                StreamReader input = new StreamReader(filename);
                string sInput = input.ReadToEnd();
                input.Close();

                instance = JsonConvert.DeserializeObject<Player>(sInput);
            }

            //Writes Player data to a JSON formatted file
            public void WritePlayerFile(string filename)
            {
                string sOutput = JsonConvert.SerializeObject(instance);

                StreamWriter output = new StreamWriter(filename);
                output.Write(sOutput);
                output.Close();

            }
        }
    }
}
