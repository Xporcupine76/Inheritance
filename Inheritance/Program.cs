using System;
namespace Inheritance
{
    class Program
    {

        static void Main(string[] args)
        {

         Adults adult1 = new Adults();

            Console.WriteLine(adult1.pName);
            Console.WriteLine(adult1.pSurname);
            Console.WriteLine(adult1.pAddress);
            adult1.Pay();
            adult1.Insurance();
            Console.WriteLine("=======");

            Child child1 = new Child();

            child1.pName = "Thorfin";
            child1.pSurname = "Son of Thours";
            child1.pAddress = "Valhaala";

            Console.WriteLine(child1.pName);
            Console.WriteLine(child1.pSurname);
            Console.WriteLine(child1.pAddress);
            Console.WriteLine("=======");

            Adults adult2 = new Adults();

            adult2.pName = "Hades";
            adult2.pSurname = "king of the underworld";
            adult2.pAddress = "Underworld";

            Console.WriteLine(adult2.pName);
            Console.WriteLine(adult2.pSurname);
            Console.WriteLine(adult2.pAddress);

        }

    }
    public class Patient
    {
        public string pName = "Thors";
        public string pSurname = "Jomsvikings";
        public string pAddress = "Valhaala";

        public void Examine()
        {

            Console.WriteLine("Patient has been ecamined");

        }


    }
    public class Adults: Patient// inheritance :
    {
        public void Pay()
        {

            Console.WriteLine("Payment Done");

        }
        public void Insurance()
        {


            Console.WriteLine("They have medical aid");
        }


    }
    public class Child: Patient
    {

        public void Innoculated()
        {


            Console.WriteLine("");
        }

    }
}