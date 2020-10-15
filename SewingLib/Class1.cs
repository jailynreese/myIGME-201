using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingLib
{
    //sew interface
    public interface Sew
    {
        void StartSewing();
        void StopSewing();
    }

    //artist interface
    public interface Artist
    {
        void GetCoupons();
        bool NeedsMaterials();

    }

    //Material abstract class
    public abstract class Material
    {
        public string threadColor;
        public int threadCount;
        public bool stretch;

        public Material()
        {
        }

        public Material(bool stretch)
        {
        }

        public abstract void CutFabric();
    }

    //Dress class inherits from Material and Sew
    public class Dress : Material, Sew
    {
        private int size;
        public double length;
        public string color;

        public override void CutFabric()
        {
        }

        public virtual void MakeDressLonger(double added)
        {
            this.length += added;
        }
        public void StartSewing()
        {
        }

        public void StopSewing()
        {
        }
    }

    //Hat inherits from Material
    public class Hat : Material
    {
        public int headSize;
        public string color;

        public override void CutFabric()
        {
        }
    }

    //Shopping class inherits from Artist
    public class Shopping : Artist
    {

        public List<Material> materialsNeeded;
        public int distanceFromHome;
        string Store
        {

            set
            {

            }
        }

        public Shopping()
        {
        }


        public void GetCoupons()
        {
        }

        public bool NeedsMaterials()
        {
            return true;
        }

    }
}
