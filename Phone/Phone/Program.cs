using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneLib;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Tardis tard = new Tardis();
            PhoneBooth pb = new PhoneBooth();

            UsePhone(tard);
            UsePhone(pb);
        }

        static void UsePhone(PhoneInterface phone)
        {
            phone.MakeCall();
            phone.HangUp();

            //calls OpenDoor if a PhoneBooth
            try
            {

                PhoneBooth tester = (PhoneBooth)phone;
                tester.OpenDoor();
            }
            catch
            {
            }

            //calls TimeTravel if Tardis
            try
            {

                Tardis tester = (Tardis)phone;
                tester.TimeTravel();
            }
            catch
            {
            }
        }
    }

}
