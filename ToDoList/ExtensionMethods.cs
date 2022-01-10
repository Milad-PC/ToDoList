using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public static class ExtensionMethods
    {
        public static string ToDateString(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"امروز {getDayName(value.DayOfWeek)} {pc.GetDayOfMonth(value)} {getMonthName(pc.GetMonth(value))} {pc.GetYear(value)}";
        }
        public static string ToShamsi(this DateTime value, bool HaveTime = false)
        {
            PersianCalendar pc = new PersianCalendar();
            if(HaveTime)
                return string.Format("{0}/{1}/{2} {3}:{4}", pc.GetYear(value), pc.GetMonth(value),
                    pc.GetDayOfMonth(value),value.Hour,value.Minute);
            else return string.Format("{0}/{1}/{2}", pc.GetYear(value), pc.GetMonth(value), pc.GetDayOfMonth(value));
        }
        static string getDayName(DayOfWeek val)
        {
            string x = string.Empty;
            switch (val)
            {
                case DayOfWeek.Sunday:
                    x = "یکشنبه";
                    break;
                case DayOfWeek.Monday:
                    x = "دوشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    x = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    x = "چهارشنبه";
                    break;
                case DayOfWeek.Thursday:
                    x = "پنج شنبه";
                    break;
                case DayOfWeek.Friday:
                    x = "جمعه";
                    break;
                case DayOfWeek.Saturday:
                    x = "شنبه";
                    break;
                default:
                    x = "نا مفهوم";
                    break;
            }
            return x;
        }
        static string getMonthName(int val)
        {
            string[] x = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان"
                    , "آذر", "دی", "بهمن", "اسفند" };
            return x[val - 1];
        }
        public static DateTime ToMiladi(string Date , string Hour = "0" , string Min = "0")
        {
            string[] x = Date.Split('/');
            PersianCalendar pc = new PersianCalendar();
            DateTime dt = new DateTime(Convert.ToInt32(x[0]), Convert.ToInt32(x[1]), Convert.ToInt32(x[2]), pc);

            return dt;
        }
    }
}
