using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebApplication2.Utilities
{
    public class DateParsing
    {
        public static DateTime ParseFinnishDate (string date)
        {
            DateTime result = DateTime.MinValue;
            String finnishFormat = "d.M.yyyy";
            try
            {
                CultureInfo fiFi = new CultureInfo("fi-FI");
                result = DateTime.ParseExact(date, finnishFormat, fiFi);
            }
            catch (Exception ex)
            {
                // TODO kirjoitetaan poikkeus lokiin
                result = DateTime.MinValue;
            }

            return result;
        }
    }
}