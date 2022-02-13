using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaTydz3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, place;
            int yearOfBirth, monthOfBirth, dayOfBirth;
            int userChoice;
            int i = 1;

            Console.WriteLine("Cześć, poproszę Cię o podanie kilku informacji o sobie, a później sprawdzimy, czy dobrze zapamiętałem!");

            try
            {
                do
                {
                    Console.WriteLine(User.GetCurrentDate());

                    Console.WriteLine("Podaj swoje imie: ");
                    name = Console.ReadLine();
                    Console.WriteLine("A gdzie się urodziłeś?");
                    place = Console.ReadLine();
                    Console.WriteLine("Teraz podaj rok urodzenia: ");
                    yearOfBirth = User.GetInputYear();
                    Console.WriteLine("Teraz podaj miesiąc urodzenia: ");
                    monthOfBirth = User.GetInputMonth();
                    Console.WriteLine("Teraz podaj dzień urodzenia: ");
                    dayOfBirth = User.GetInputDay(yearOfBirth, monthOfBirth);

                    DateTime userDateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
                    Console.WriteLine(userDateOfBirth);

                    User thisUser = new User(name, place, yearOfBirth, monthOfBirth, dayOfBirth);

                    Console.WriteLine("Teraz sprawdźmy, czy dobrze zapamiętałem...");

                    thisUser.ReadAllData();

                    Console.WriteLine("Chcesz powtórzyć trening?\n1. Tak!\n2. Nie.");
                    userChoice = User.GetInputData();

                    if (userChoice == 1)
                        i++;
                }
                while (userChoice != 2) ;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
            }
        }
    }
}
