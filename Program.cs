using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.crediCalculatorBase = new Before210CreditCalculator();
            customerManager.SaveCredit();

            customerManager.crediCalculatorBase = new After210CreditCalculator();
            customerManager.SaveCredit();
            Console.ReadLine();

        }
    }
    abstract class CrediCalculatorBase
    {
        public abstract void Calculate();
    }
    class Before210CreditCalculator : CrediCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using before210");
        }
    }
    class After210CreditCalculator : CrediCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using after210");
        }
    }
    class CustomerManager
    {
        public CrediCalculatorBase crediCalculatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            crediCalculatorBase.Calculate();
        }
    }

}
