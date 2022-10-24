using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

//This program demonstrates the use of classes and interfaces
//Author: Nick Will
namespace Will_UnitTest2_7
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                this.phoneNumber = value;
            }
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }

    public interface PhoneInterface
    {
        void Answer();

        void MakeCall();

        void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }

    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {
            
        }

    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get
            {
                return whichDrWho;
            }
        }

        public string FemaleSideKick
        {
            get
            {
                return femaleSideKick;
            }
        }

        public void TimeTravel()
        {

        }

        public static bool operator == (Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator != (Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho != t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator > (Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == 10 && t2.whichDrWho != 10)
            {
                return true;
            }
            else if (t2.whichDrWho == 10 && t1.whichDrWho != 10)
            {
                return false;
            }
            else if (t1.WhichDrWho > t2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator < (Tardis t1, Tardis t2)
        {
            if (t1.WhichDrWho == 10 && t2.whichDrWho != 10)
            {
                return false;
            }
            else if (t2.whichDrWho == 10 && t1.whichDrWho != 10)
            {
                return true;
            }
            else if (t1.WhichDrWho < t2.WhichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >= (Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == t2.whichDrWho || t1.whichDrWho > t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <= (Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == t2.whichDrWho || t1.whichDrWho < t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        { 

        }

    }

    internal class Program
    {
        public static void Main()
        {
            Tardis myTardis = new Tardis();
            PhoneBooth myPhoneBooth = new PhoneBooth();


        }

        static void UsePhone(object obj)
        {
            if (obj is PhoneBooth)
            {
                PhoneBooth myPhoneBooth = (PhoneBooth)obj;
                myPhoneBooth.OpenDoor();
            }
            else if (obj is Tardis)
            {
                Tardis myTardis = (Tardis)obj;
                myTardis.TimeTravel();
            }

            PhoneInterface myPhoneInterface = (PhoneInterface)obj;
            myPhoneInterface.MakeCall();
            myPhoneInterface.HangUp();
        }
    }
    
}
