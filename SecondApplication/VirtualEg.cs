using System;
using System.Collections.Generic;
using System.Text;

namespace SecondApplication
{
    class UGC
    {
        string[] rules = { "Dress Code", "Identity Card" };
        public virtual void RulesMethod()
        {
            foreach(var r in rules)
            {
                Console.WriteLine("Rule:{0}", r);
            }
        }
    }
    class MIT : UGC
    {
        string mitrule = "No Mobile";
        public override void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("MIT Rules:{0}", mitrule);
        }
    }

    class AnnaUniversity : UGC
    {
        string annarule = "Only formal dress";
        public new void RulesMethod()
        {
            base.RulesMethod();
            Console.WriteLine("AnnaUniversity Rules:{0}", annarule);
        }
    }
    class VirtualEg
    {
        static void Main()
        {
            UGC ugc = new UGC();
            Console.WriteLine("UGC Rules");
            ugc.RulesMethod();
            Console.WriteLine("MIT Rules");
            MIT mitobj = new MIT();
            mitobj.RulesMethod();
        }
    }
}
