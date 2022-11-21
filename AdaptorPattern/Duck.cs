using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public interface Duck
    {
        void quack();
        void fly();
    }
    public class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("I am flying");
        }

        public void quack()
        {

            Console.WriteLine("Quack");
        }
    }
    public interface Turkey
    {
        void fly();
        void Gobble();
    }
    public class wildTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine("I am flying a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
    public class TurkeyAdaptor : Duck
    {
        Turkey _turkey;
        public TurkeyAdaptor(Turkey turkey)
        {
            _turkey= turkey;
        }
        public void quack()
        {
            _turkey.Gobble();
        }

        public void fly()
        {
           for(int i=0;i<5;i++)
           {
                _turkey.fly();
           }
        }
    }

}
