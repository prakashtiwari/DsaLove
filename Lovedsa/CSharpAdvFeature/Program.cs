using CSharpAdvFeature.Components;
using CSharpAdvFeature.DelegatePract;
using System;
using System.Collections.Generic;
using static CSharpAdvFeature.DelegatePract.Photoprocessor;

namespace CSharpAdvFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //NullTesting nullTesting = new NullTesting();

            //var list = new List<int[]>();
            //list.Add(new int[] { 1, 2 });
            //list.Add(null);
            ////  var result = nullTesting.SumNumbers(list, 1);
            //DynamicType dynamicType = new DynamicType();
            //dynamicType.GetData();
            //PhotoFilters photo = new PhotoFilters();
            //PhotoFilters photoFilters = new PhotoFilters();
            //Photoprocessor photoprocessor = new Photoprocessor();
            //Photoprocessor.PhotoProcessHandler processHandler = photoFilters.ApplyBrightness;
            //Action<Photo> processHandlerAct = photoFilters.ApplyBrightness;
            ////processHandler += photoFilters.ApplyBrightness;
            //photoprocessor.ProcessPhotoNew("", processHandlerAct);

            Func<int, int> mul = num => num * num;
            Console.WriteLine($"Multiplication is {mul(5)}");

            Console.ReadLine();


        }
        public static void ApplyDarkness(Photo pho)
        {
            Console.WriteLine("DArkness applied");
        }
    }
}
