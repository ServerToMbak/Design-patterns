using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonClass
    {
        private static SingletonClass instance;
        private SingletonClass(){  }
        public static SingletonClass Instance()
        {
            
            if(instance==null)
            {
                instance = new SingletonClass();
            }
            return instance;
        }
    }
}
