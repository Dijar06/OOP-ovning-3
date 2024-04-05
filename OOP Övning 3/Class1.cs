using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Övning_3
{
    class Class1
    {
        private string förnamn;
        private string efternamn;
        public int ålder;

        public string metod1
        {
            get { return förnamn; }
            set { förnamn = value; }
        }

        public string metod2
        {
            get { return efternamn; }
            set { efternamn = value; }
        }

        public bool myndig()
        {
            return ålder >= 18;
        }
    }
}
