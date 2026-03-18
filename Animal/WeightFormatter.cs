using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NCSafari
{
    public class WeightFormatter : IFormattable
    {
        public Animals Animal;

        public WeightFormatter(Animals animal)
        {
            Animal = animal;
        }



        //Implement IFormattable to format weight with kg and oz whilst also changing culture from en-GB to de-DE
        public string ToString(string? format, IFormatProvider? formatProvider) //format = kg/oz. formatProvider = en-GB/de-DE.
        {
            float weight = Animal.WeightInKG;
            float ozWeight = weight * 35.274f;
            string result = $"The {this.GetType().Name}\\'s weight is {weight} kg";

            if (format == null)
            {
                format = "kg";
                Console.WriteLine($"The {this.GetType().Name}\'s weight is {weight} kg");
                Console.WriteLine($"The {this.GetType().Name}\'s weight is {ozWeight} oz");
                //If no weight is given default to kilograms.
            }

            format.ToLower();

            if (format == "kg")
            {
                Console.WriteLine($"The {this.GetType().Name}\'s weight is {weight} kg");
                Console.WriteLine($"The {this.GetType().Name}\'s weight is {ozWeight} oz");
            }

            if (format == "oz")
            {

                Console.WriteLine($"The {this.GetType().Name}\'s weight is {ozWeight} oz");
                Console.WriteLine($"The {this.GetType().Name}\'s weight is {weight} kg");
            }
            return result;
        }
        //CultureInfo culture = new CultureInfo("de-DE");
        //// **EXAMPLE FOUND ONLINE**

        //format = format.ToUpper();

        ////        return format switch
        ////{
        ////    "G" or "FULL" => $"{FirstName} {LastName} is the {JobTitle} at {CompanyName}",
        ////    "L" or "LOGIN" => $"{FirstName}.{LastName}",
        ////    "UD" or "USERDOMAIN" => $"{FirstName}.{LastName}@{CompanyName}.local",
        ////    _ => throw new FormatException($"Invalid format {format}")
        ////};
        ////Return its weight in kg formatted in both en-GB and de-DE

        ////Return weight converted to ounces formatted in both en-GB and de-DE
    }
}
