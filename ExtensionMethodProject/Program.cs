using System;

namespace ExtensionMethodProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestClass _objTestClass = new TestClass();
            _objTestClass.Test1();
            _objTestClass.Test2();
            _objTestClass.Test3();

            int i = 5;
            int result = i.Factorial();
            Console.WriteLine("Factorial Of {0} is {1}",i,result);

            string str = "how Are you jaan Love you";
            string properstring = str.ToProper();
            Console.WriteLine("Old String : "+str);
            Console.WriteLine("New String : "+properstring);
            Console.ReadLine();
        }
    }
}

/*
 * Extension Method is A Mechanism To Add a method into a class or struts in such a way that it needs no permission and recompilation
 * We Have To Make A Static class And A Static Method Within It.
 * Now We Have To Add A Method into Test Class
 */
