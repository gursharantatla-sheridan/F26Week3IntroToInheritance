namespace F26Week3IntroToInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objBase = new BaseClass();
            objBase.myPublicVar = 1;
            //objBase.myProtectedVar = 2;

            DerivedClass objDerived = new DerivedClass();
            objDerived.myPublicVar = 3;
            //objDerived.myProtectedVar = 4;
        }
    }
}
