using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public abstract class Dream
    {
        public string makeADream { get; set; }
    }
    public class IndividualDream : Dream
    {
        public IndividualDream()
        {
            makeADream = "Its an Individual Dream and not that easy to get but it worth to get";

        }
    }
    public class FamilyDream : Dream
    {
        public FamilyDream()
        {
            makeADream = "Its an Family Dream hard to get but more hard to feed";
        }
    }
    public interface IDreamFactory
    {
         Dream makeTheDreamYouWısh(string DreamName);
    }
    public class DreamFactory : IDreamFactory
    {
        public Dream makeTheDreamYouWısh(string DreamName)
        {
           if(DreamName == "Individual")
            {
                return new IndividualDream();
            }
           else if(DreamName == "Family"){
                return new FamilyDream();
           }
            else
            {
                throw new ArgumentException("You are in the wrong Dream wake up!");
            }
        }
    }
}
