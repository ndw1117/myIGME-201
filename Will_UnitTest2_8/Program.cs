using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# Code based off of a data model for one of my favorite hobbies: playing rugby
//Author: Nick Will
namespace Will_UnitTest2_8
{
    public abstract class RugbyPlayer
    {
        private string nickname;
        public int position;

        public string Nickname
        {
            get
            {
                return nickname;
            }
        }

        public void Run()
        {

        }

        public abstract void Pass();

        public abstract void Tackle();

        public virtual void Offload()
        {

        }
    }

    public interface Forward
    {
        void Scrum();
        void PodAttack();
    }

    public interface Back
    {
        void BreakAway();

        void Kick();
    }

    public class EightMan : RugbyPlayer, Forward
    {
        public bool isBigAndScary;

        public void Scrum()
        {

        }

        public void PodAttack()
        { 

        }

        public override void Pass()
        {
            
        }

        public override void Tackle()
        {
            
        }

        public override void Offload()
        {

        }

    }

    public class StrongSideWing : RugbyPlayer, Back
    {
        public bool isFast;

        public void BreakAway()
        {

        }

        public void Kick()
        {

        }

        public override void Pass()
        {

        }

        public override void Tackle()
        {
         
        }

        public override void Offload()
        {
           
        }
    }

    //Class: Program
    //Author: Nick Will
    //Purpose: Demonstrates polymorphism using the classes defined above
    //Restrictions: None
    public class Program
    {
        public static void main()
        {
            StrongSideWing strongSideWing = new StrongSideWing();
            EightMan eightMan = new EightMan();


        }

        static void myMethod(object obj)
        {
            if (obj is StrongSideWing)
            {
                StrongSideWing strongSideWing = (StrongSideWing)obj;
                strongSideWing.Kick();
                strongSideWing.BreakAway();
                strongSideWing.Run();
                strongSideWing.Offload();
                strongSideWing.Tackle();
                strongSideWing.Pass();
                
            }

            if (obj is EightMan)
            {
                EightMan eightMan = (EightMan)obj;
                eightMan.Scrum();
                eightMan.PodAttack();
                eightMan.Run();
                eightMan.Offload();
                eightMan.Tackle();
                eightMan.Pass();
            }
        }
    }

}
