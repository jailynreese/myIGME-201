using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface Mood
    {
        string Mood { get; }
    }

    public class Waiter : Mood
    {
        public string name;
        public string Mood { get; }
        public void ServeCustomer(HotDrink cup)
        {
        }
    }

    public class Customer : Mood
    {
        public string name;
        public string creditCardNumber;
        public string Mood { get; }
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string brand;
        public string size;
        public Customer customer;

        public HotDrink()
        {
        }

        public HotDrink(string brand)
        {
        }

        public virtual void AddSugar(byte amount)
        {
        }

        public abstract void Steam();
    }

    public class CupOfCoffee : HotDrink, TakeOrder
    {
        public string beanType;

        public CupOfCoffee()
        {
        }

        public CupOfCoffee(string brand) : base(brand)
        {
        }

        public override void Steam()
        {
        }

        public void TakeOrder()
        {
        }
    }

    public class CupOfTea : HotDrink, TakeOrder
    {
        public string leafType;

        public CupOfTea(bool CustomerIsWealthy)
        {
        }

        public override void Steam()
        {
        }

        public void TakeOrder()
        {
        }

    }

    public class CupOfCocoa : HotDrink, TakeOrder
    {
        public static int numCups;
        public bool marshmallows;
        private string source;

        public CupOfCocoa()
        {
            this.marshmallows = false;
        }

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {
        }
        public string Source
        {
            set
            {
            }
        }

        public override void Steam()
        {
        }

        public override void AddSugar(byte amount)
        {
        }

        public void TakeOrder()
        {
        }

    }

    public interface TakeOrder
    {
        void TakeOrder();
    }

}
