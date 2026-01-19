using System;
using System.Collections.Generic;
using System.Text;

namespace F26Week3IntroToInheritance
{
    public class BaseClass
    {
        // fields
        private int myPrivateVar;
        protected int myProtectedVar;
        public int myPublicVar;

        // constructor
        public BaseClass()
        {
            Console.WriteLine("Base class constructor called");
        }

        public BaseClass(string msg)
        {
            Console.WriteLine("Base class constructor with message: " + msg);
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base("hello")
        {
            Console.WriteLine("Derived class constructor called");
        }

        public DerivedClass(string msg) : base(msg)
        {
            Console.WriteLine("Derived class constructor called");
        }

        public void MyMethod()
        {
            //myPrivateVar = 1;
            myProtectedVar = 2;
            myPublicVar = 3;
        }
    }
}
