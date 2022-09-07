﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDeProg
{
    public abstract class De
    {
        protected const int nombreDeFaces = 6;
        public string typeDeDe;
        public De(string typeDeDe)
        {
            this.typeDeDe = "";
        }
        public virtual int Brasser()
        {
            Random random = new Random();

            return random.Next(1, nombreDeFaces + 1);
        }
    }
}