using LinkPractice.LeftJoin;
using System;

namespace LinkPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            LinqLeftJoin lj = new LinqLeftJoin();
            var result = lj.GetStudentDetail();
            foreach (var i in result)
            {
                Console.WriteLine($"Name is {i.Name} and Dept is: {i.DeptName}");
            }
        }
    }
}
