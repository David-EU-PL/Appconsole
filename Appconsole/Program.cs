namespace Appconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię");
            var name = Console.ReadLine();

            Console.WriteLine("\nPodaj swój rok urodzenia");
            var yearOfBirth = GetYear();

            Console.WriteLine("\nPodaj swój miesiąc urodzenia");
            var monthOfBirth = GetMonth();

            Console.WriteLine("\nPodaj swój dzień urodzenia");
            var dayOfBirth = GetDayOfMonth(yearOfBirth, monthOfBirth);

            Console.WriteLine("\nW jakiej miejscowości się urodziłeś/aś?");
            var placeOfBirth = Console.ReadLine();

            var dateofBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            var age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear)
                age--;
            Console.WriteLine($"Cześć {name}. Urodziłeś się w {placeOfBirth} i masz {age} lat.");
        }

        private static int GetDayOfMonth(int yearOfBirth, int monthOfBirth)
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day > DateTime.DaysInMonth(yearOfBirth, monthOfBirth) || day < 1)
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie");
                    continue;

                }

                return day;
            }
        }

        private static int GetMonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie");
                    continue;

                }

                return month;
            }
        }

        private static int GetYear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year > DateTime.Now.Year)
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane. Spróbuj ponownie");
                    continue;
                   
                }

                return year;
            }
            
        }
    }

}

