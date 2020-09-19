using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    abstract class Vehicle
    {
        public virtual void LoadPassenger()
        {

        }
    }

    abstract class Car : Vehicle
    {

    }

    interface IPassengerCarrier
    {
        void LoadPassenger()
        {
    
        }
    }

    interface IHeavyLoadCarrier
    {
    }

    abstract class Train
    {
    }

    class Compact : Car, IPassengerCarrier
    {
    }

    class SUV : Car, IPassengerCarrier
    {
    }

    class Pickup : Car, IHeavyLoadCarrier
    {
    }

    class PassengerTrain : Train, IPassengerCarrier
    {
    }

    class FreightTrain : Train, IHeavyLoadCarrier
    {
    }

    class _424DoubleBuggy: Train, IHeavyLoadCarrier
    {
    }

}
