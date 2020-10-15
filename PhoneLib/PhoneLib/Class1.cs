using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneLib
{
    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber;
        public string address;

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
        private bool sonicScrewdiver;
        private byte whichDrWho;
        private byte WhichDrWho
        {
            get;
        }
        private string femaleSideKick;
        public string FemaleSideKick
        {
            get;
        }
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public void TimeTravel()
        {
        }

        //overloading the boolran operators
        //adding exception for 10th doctor
        public static bool operator <(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == t2.whichDrWho)
            {
                return false;
            }

            if(t1.whichDrWho == 10)
            {
                return false;
            }

            if(t2.whichDrWho == 10)
            {
                return true;
            }

            return (t1.whichDrWho < t2.whichDrWho);
        }

        public static bool operator >(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == t2.whichDrWho)
            {
                return false;
            }

            if (t1.whichDrWho == 10)
            {
                return true;
            }

            if (t2.whichDrWho == 10)
            {
                return false;
            }

            return (t1.whichDrWho < t2.whichDrWho);
        }

        public static bool operator ==(Tardis t1, Tardis t2)
        {
            if(t1.whichDrWho == t2.whichDrWho)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static bool operator !=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho != t2.whichDrWho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == t2.whichDrWho)
            {
                return true;
            }

            if (t1.whichDrWho == 10)
            {
                return false;
            }

            if (t2.whichDrWho == 10)
            {
                return true;
            }

            return (t1.whichDrWho < t2.whichDrWho);
        }

        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == t2.whichDrWho)
            {
                return true;
            }

            if (t1.whichDrWho == 10)
            {
                return true;
            }

            if (t2.whichDrWho == 10)
            {
                return false;
            }

            return (t1.whichDrWho > t2.whichDrWho);
        }
    }

    public class PhoneBooth: PushButtonPhone
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


}
