using System;
using System.Collections.Generic;
namespace ConvertBase_Classes_V1_0
{

    public static class ConvertBase
    {
        public static string ConvertDoubleToStringBase(Enums.NumerationSystem numerationSystem, double value)
        {
            switch (numerationSystem)
            {
                case Enums.NumerationSystem.Binary:
                    return ToBinary(value);
                case Enums.NumerationSystem.Decimal:
                    return $"{value}";
                case Enums.NumerationSystem.Hexadecimal:
                    return ToHexadecimal(value);
                case Enums.NumerationSystem.Octal:
                    return ToOctal(value);
                case Enums.NumerationSystem.Trigecimal:
                    return ToTrigecimal(value);
                case Enums.NumerationSystem.Sexagecimal:
                    return ToSexagecimal(value);
                default:
                    return string.Empty;
            }
            string ToBinary(double decimal_Value)
            {
                string binary_Value = string.Empty;
                string[] binary_Terms = new string[] { "0", "1", };
                while (true)
                {
                    double base_Count = binary_Terms.Length;
                    binary_Value = $"{binary_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{binary_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { binary_Value = $"{binary_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{binary_Value}"; break; }
                }
                return binary_Value;
            }
            string ToHexadecimal(double decimal_Value)
            {
                string hexadecimal_Value = string.Empty;
                string[] hexadecimal_Terms = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", };
                while (true)
                {
                    double base_Count = hexadecimal_Terms.Length;
                    hexadecimal_Value = $"{hexadecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{hexadecimal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { hexadecimal_Value = $"{hexadecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{hexadecimal_Value}"; break; }
                }
                return hexadecimal_Value;                
            }
            string ToOctal(double decimal_Value)
            {
                string octal_Value = string.Empty;
                string[] octal_Terms = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", };
                while (true)
                {
                    double base_Count = octal_Terms.Length;
                    octal_Value = $"{octal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{octal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { octal_Value = $"{octal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{octal_Value}"; break; }
                }
                return octal_Value;
            }
            string ToTrigecimal(double decimal_Value)
            {
                string trigecimal_Value = string.Empty;
                string[] trigecimal_Terms = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
                while (true)
                {
                    double base_Count = trigecimal_Terms.Length;
                    trigecimal_Value = $"{trigecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{trigecimal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { trigecimal_Value = $"{trigecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{trigecimal_Value}"; break; }
                }
                return trigecimal_Value;
            }
            string ToSexagecimal(double decimal_Value)
            {
                string sexagecimal_Value = string.Empty;
                string[] sexagecimal_Terms = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
                while (true)
                {
                    double base_Count = sexagecimal_Terms.Length;

                    sexagecimal_Value = $"{sexagecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{sexagecimal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { sexagecimal_Value = $"{sexagecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{sexagecimal_Value}"; break; }
                }
                return sexagecimal_Value;

            }
        }
        public static string ConvertDoubleToStringBase(double value, char[] ValuesBase)
        {
            double base_Count = ValuesBase.Length;
            string base_Value = string.Empty;
            while (true)
            {
                base_Value = $"{ValuesBase[Convert.ToInt32(value % base_Count)]}{base_Value}";
                value = (value - (value % base_Count)) / base_Count;
                if (value < base_Count) { base_Value = $"{ValuesBase[Convert.ToInt32(value % base_Count)]}{base_Value}"; break; }
            }
            return base_Value;
        }

        public static double ConvertStringBaseToDouble(Enums.NumerationSystem numerationSystem, string value)
        {
            switch (numerationSystem)
            {
                case Enums.NumerationSystem.Binary:
                    return ToBinary(value);
                case Enums.NumerationSystem.Decimal:
                    return Convert.ToDouble(value);
                case Enums.NumerationSystem.Hexadecimal:
                    return ToHexadecimal(value);
                case Enums.NumerationSystem.Octal:
                    return ToOctal(value);
                case Enums.NumerationSystem.Trigecimal:
                    return ToTrigecimal(value);
                case Enums.NumerationSystem.Sexagecimal:
                    return ToSexagecimal(value);
                default:
                    return 0;
            }
            double ToBinary(string binary_Value)
            {
                List<char> binary_Terms = new List<char>() { '0', '1', };
                double b_Value = 0;
                double @base = binary_Terms.Count;
                double @exponent = binary_Value.Length - 1;
                foreach (char x in binary_Value)
                {
                    b_Value += binary_Terms.IndexOf(x) * Math.Pow(@base, @exponent);
                    @exponent--;
                }

                return b_Value;
            }
            double ToHexadecimal(string hexadecimal_Value)
            {
                List<char> hexadecimal_Terms = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', };
                double h_Value = 0;
                double @base = hexadecimal_Terms.Count;
                double @exponent = hexadecimal_Value.Length - 1;
                foreach (char x in hexadecimal_Value)
                {
                    h_Value += hexadecimal_Terms.IndexOf(x) * Math.Pow(@base, @exponent);
                    @exponent--;
                }

                return h_Value;
            }
            double ToOctal(string octal_Value)
            {
                List<char> octal_Terms = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', };
                double o_Value = 0;
                double @base = octal_Terms.Count;
                double @exponent = octal_Value.Length - 1;
                foreach (char x in octal_Value)
                {
                    o_Value += octal_Terms.IndexOf(x) * Math.Pow(@base, @exponent);
                    @exponent--;
                }

                return o_Value;
            }
            double ToTrigecimal(string trigecimal_Value)
            {
                List<char> trigecimal_Terms = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', };
                double t_Value = 0;
                double @base = trigecimal_Terms.Count;
                double @exponent = trigecimal_Value.Length - 1;
                foreach (char x in trigecimal_Value)
                {
                    t_Value += trigecimal_Terms.IndexOf(x) * Math.Pow(@base, @exponent);
                    @exponent--;
                }

                return t_Value;
            }
            double ToSexagecimal(string sexagecimal_Value)
            {
                List<char> sexagecimal_Terms = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', };
                double s_Value = 0;
                double @base = sexagecimal_Terms.Count;
                double @exponent = sexagecimal_Value.Length - 1;
                foreach (char x in sexagecimal_Value)
                {
                    s_Value += sexagecimal_Terms.IndexOf(x) * Math.Pow(@base, @exponent);
                    @exponent--;
                }

                return s_Value;

            }
        }
        public static double ConvertStringBaseToDouble(string value, char[] ValuesBase)
        {
            double base_Value = 0;
            double base_Count = ValuesBase.Length;
            double exponent_Count = value.Length;
            foreach (char x in value)
            {
                base_Value += value.IndexOf(x) * Math.Pow(base_Count, exponent_Count);
                exponent_Count--;
            }
            return base_Value;
        }
    }

    public static class Enums
    {
        public enum NumerationSystem
        {
            Binary,
            Hexadecimal,
            Octal,
            Decimal,
            Trigecimal,
            Sexagecimal
        }
    }

}

