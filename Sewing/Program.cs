using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewing
{
    public interface Sew
    {
        void StartSewing();
        void StopSewing();
    }

    public interface Artist
    {
        void GetCoupons();
        bool NeedsMaterials(); 

    }

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

    public class Dress: Material, Sew 
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

    public class Hat: Material
    {
        public int headSize;
        public string color;

        public override void CutFabric()
        {
        }
    }

    public class Shopping: Artist
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


