using System;

namespace Practice8
{
    struct Birthday
    {
        public DateTime DateBirthday;
        public Birthday(DateTime date)
        {
            DateBirthday = date;
        }


        public DayOfWeek GetDayOfWeek()
        {
            return DateBirthday.DayOfWeek;
        }

        public DayOfWeek GetDayOfWeek(int year)
        {
            DateTime dateFound = new DateTime(year, DateBirthday.Month, DateBirthday.Day);

            return dateFound.DayOfWeek;
        }
        

        public int DaysBeforBirthday()
        {
            DateTime today = DateTime.Today;

            DateTime ThisYearBirthday = new DateTime(today.Year, DateBirthday.Month,DateBirthday.Day);

            TimeSpan differec = ThisYearBirthday - today;

            return differec.Days;
        }

        public override string ToString()
        {
            return $"Year: {DateBirthday.Year} month: {DateBirthday.Month} day: {DateBirthday.Day}";
        }




    }
}
