using System.Transactions;

namespace My_First_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //oop =>Object Oriented Programming
            //Java, PHP, C# ,VB, TypeScript
            //Class
            //string, int, boolean, date, object => primitive tip => ilkel tip
            //string nameLastname = "Merve Akça"; //Değişken oluşturma
            //string email = "smkirac@gmail.com"; //Değişken oluşturma
            //state
            //İsimlendirme Kuralları
            //values

            //ram=bellek=memory => ram parçası

            string name = "Merve";
            double pi = 3.14;
            int age = 35;
            decimal money = 100.10m;
            double money2 = 100.10;
            decimal money3 = money;
            DateTime now = DateTime.Now;
            bool isTrue=true; // (0 => yanlış => false) - (1 => doğru => true)
            object user = new { };

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(money);
            Console.WriteLine(now);
            Console.WriteLine(isTrue);
        }
    }
}