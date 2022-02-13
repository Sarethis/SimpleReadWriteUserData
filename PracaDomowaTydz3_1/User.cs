using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowaTydz3_1
{
    internal class User
    {
        private string _name;
        private string _placeOfLiving;
        private int _yearOfBirth;
        private int _monthOfBirth;
        private int _dayOfBith;

        static int CurrentYear = DateTime.Now.Year;
        static int CurrentMonth = DateTime.Now.Month;
        static int CurrentDay = DateTime.Now.Day;

        public User(string name, string placeOfLiving, int yearOfBirth, int monthOfBirth, int dayOfBirth)
        {
            _name = name;
            _placeOfLiving = placeOfLiving;
            _yearOfBirth = yearOfBirth;
            _monthOfBirth = monthOfBirth;
            _dayOfBith = dayOfBirth;
        }
        public static int GetInputData()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int variable))
                {
                    Console.WriteLine("Podana wartość nie jest liczbą.\nPodaj poprawną wartość:");
                    continue;
                }
                return variable;
            }
        }

        public static int GetInputYear()
        {
            while (true)
            { 
                if (!int.TryParse(Console.ReadLine(), out int variable) || variable < 1902 || variable > DateTime.Now.Year)
                {
                    Console.WriteLine("Podana wartość nie jest rokiem między 1902 a 2022... Chyba nie masz więcej niż 120 lat oraz urodziłeś się już.\nPodaj poprawną wartość:");
                    continue;
                }
                return variable; 
            }
        }
        public static int GetInputMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int variable) || variable < 1 || variable > 12)
                {
                    Console.WriteLine("Podana wartość nie jest numerem miesiąca z planety Ziemia.\nPodaj jeszcze raz poprawną wartość:");
                    continue;
                }
                return variable;
            }
        }
        public static int GetInputDay(int year, int month)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int variable) || variable < 1 || variable > DateTime.DaysInMonth(year, month))
                {
                    Console.WriteLine("Podana wartość nie jest poprawną liczbą dni.\nPodaj poprawną wartość:");
                    continue;
                }
                return variable;
            }
        }
        public static DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }
        
        public int ReturnUserAge()
        {
            int UserAge = CurrentYear - _yearOfBirth;
            if (_dayOfBith > CurrentDay && _monthOfBirth >= CurrentMonth)
            {
                UserAge--;
            }
            return UserAge;
        }

        public void ReadAllData()
        {
            Console.WriteLine($"Cześć {_name}! Urodziłeś się w {_placeOfLiving}. Masz {ReturnUserAge()} lat!");
        }
    }
}
