using System;

namespace inheritance
{
    abstract class Parent
    {
        protected static Random rnd = new Random();

        protected int n;

        protected bool entry = false;

        protected Parent(int n, bool entry = false)
        {
            this.n = n;
            this.entry = entry;
        }

        public abstract void RndEntry();

        public abstract void UserEntry();

        public abstract void Print();

        public abstract double AverageValue();
    }

}
