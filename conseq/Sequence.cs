using System;
using System.Linq;

namespace conseq
{
    public class Sequence
    {
        private int[] t;

        public int[] GetT()
        {
            return t;
        }

        protected void SetT(int[] value)
        {
            t = value;
        }

        public Sequence(uint cnt, int ll, int ul) => initSeq(cnt, ll, ul);

        private void initSeq(uint cnt, int ll, int ul)
        {
            Random rnd = new Random();
            SetT(new int[cnt]);
            for (int i = 0; i < GetT().Length; i++)
            {
                GetT()[i] = rnd.Next(ll, ul + 1);
            }
        }

        public Sequence(uint cnt) : this(cnt, -100, 100) {}
        public Sequence() : this(20) {}
        //Házi feladat: Definiáljuk először a param. nélküli metódust, majd ennek 
        //felhasználásával az egyparaméterest, majd ezzel a kétparaméterest!

        /// <summary>
        /// A t elemeinek megjelenítése
        /// </summary>
        public void show(){
            for(int i=0;i< GetT().Length;i++)
                    System.Console.Write($"{i}. elem: {GetT()[i]},\t");
            System.Console.WriteLine( );
        }
    }
}