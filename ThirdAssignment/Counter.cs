using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    public sealed class Counter
    {
        public static int countvalue;
        private Counter()
        {
            countvalue = 0;
        }

        private static Counter instance = null;
       
        public static Counter GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Counter();
                }
                return instance;
            }
        }

        public int count
        {
            get
            {
                return countvalue;
            }
        }

        public void increment()
        {
            countvalue++;
        }
        public void decrement()
        {
            countvalue--;
        }
    }
}
