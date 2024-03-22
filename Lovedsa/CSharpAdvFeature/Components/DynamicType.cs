using System;

namespace CSharpAdvFeature.Components
{
    public class DynamicType
    {
        public dynamic GetData()
        {
            dynamic a = "Prakash";
            Console.WriteLine($"A is: {a}");
            a = 10;
            Console.WriteLine($"A is: {a}");
            return a;

        }
    }
}
