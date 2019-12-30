using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    class singleton
    {
       
            private static singleton  instance = null;
            public static singleton Instance
        { get
            { if (instance == null)
                    instance = new singleton();
                return instance;

                    }
        }



        private singleton()
        {
            Console.WriteLine("object printed");
        }
        public void message()
        {
            Console.WriteLine("ok");
        }
        

    
    }
}
