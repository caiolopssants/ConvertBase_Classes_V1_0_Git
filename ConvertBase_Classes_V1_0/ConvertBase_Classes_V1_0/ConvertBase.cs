using System;
using System.Collections.Generic;
using System.Linq;
namespace ConvertBase_Classes_V1_0
{
    public static class ConvertBase
    {
        public static string ConvertToStringBase(Enums.NumerationSystem numerationSystem, double value)
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
                string[] binary_Terms = new string[]
                {
                    "0",
                    "1",
                };
                while (true)
                {
                    double base_Count = binary_Terms.Length;
                    binary_Value = $"{binary_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{binary_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { binary_Value = Convert.ToInt32(decimal_Value % base_Count) == 0 ? binary_Value : $"{binary_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{binary_Value}"; break; }
                }
                return binary_Value;
            }
            string ToOctal(double decimal_Value)
            {
                string octal_Value = string.Empty;
                string[] octal_Terms = new string[]
                {
                    "0",
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                };
                while (true)
                {
                    double base_Count = octal_Terms.Length;
                    octal_Value = $"{octal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{octal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { octal_Value = Convert.ToInt32(decimal_Value % base_Count) == 0 ? octal_Value : $"{octal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{octal_Value}"; break; }
                }
                return octal_Value;
            }
            string ToHexadecimal(double decimal_Value)
            {
                string hexadecimal_Value = string.Empty;
                string[] hexadecimal_Terms = new string[]
                {
                    "0",
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "A" ,
                    "B" ,
                    "C" ,
                    "D" ,
                    "E" ,
                    "F" ,
                };
                while (true)
                {
                    double base_Count = hexadecimal_Terms.Length;
                    hexadecimal_Value = $"{hexadecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{hexadecimal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { hexadecimal_Value = Convert.ToInt32(decimal_Value % base_Count) == 0 ? hexadecimal_Value : $"{hexadecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{hexadecimal_Value}"; break; }
                }
                return hexadecimal_Value;
            }
            string ToTrigecimal(double decimal_Value)
            {
                string trigecimal_Value = string.Empty;
                string[] trigecimal_Terms = new string[]
                {
                    "0",
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "A" ,
                    "B" ,
                    "C" ,
                    "D" ,
                    "E" ,
                    "F" ,
                    "G" ,
                    "H" ,
                    "I" ,
                    "J" ,
                    "K" ,
                    "L" ,
                    "M" ,
                    "N" ,
                    "O" ,
                    "P" ,
                    "Q" ,
                    "R" ,
                    "S" ,
                    "T" ,
                    "U" ,
                    "V" ,
                    "W" ,
                    "X" ,
                    "Y" ,
                    "Z" ,
                };
                while (true)
                {
                    double base_Count = trigecimal_Terms.Length;
                    trigecimal_Value = $"{trigecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{trigecimal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { trigecimal_Value = Convert.ToInt32(decimal_Value % base_Count) == 0 ? trigecimal_Value : $"{trigecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{trigecimal_Value}"; break; }
                }
                return trigecimal_Value;
            }
            string ToSexagecimal(double decimal_Value)
            {
                string sexagecimal_Value = string.Empty;
                string[] sexagecimal_Terms = new string[]
                {
                    "0",
                    "1",
                    "2",
                    "3",
                    "4",
                    "5",
                    "6",
                    "7",
                    "8",
                    "9",
                    "a" ,
                    "b" ,
                    "c" ,
                    "d" ,
                    "e" ,
                    "f" ,
                    "g" ,
                    "h" ,
                    "i" ,
                    "j" ,
                    "k" ,
                    "l" ,
                    "m" ,
                    "n" ,
                    "o" ,
                    "p" ,
                    "q" ,
                    "r" ,
                    "s" ,
                    "t" ,
                    "u" ,
                    "v" ,
                    "w" ,
                    "x" ,
                    "y" ,
                    "z" ,
                    "A" ,
                    "B" ,
                    "C" ,
                    "D" ,
                    "E" ,
                    "F" ,
                    "G" ,
                    "H" ,
                    "I" ,
                    "J" ,
                    "K" ,
                    "L" ,
                    "M" ,
                    "N" ,
                    "O" ,
                    "P" ,
                    "Q" ,
                    "R" ,
                    "S" ,
                    "T" ,
                    "U" ,
                    "V" ,
                    "W" ,
                    "X" ,
                    "Y" ,
                    "Z" ,
                };
                while (true)
                {
                    double base_Count = sexagecimal_Terms.Length;

                    sexagecimal_Value = $"{sexagecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{sexagecimal_Value}";
                    decimal_Value = (decimal_Value - (decimal_Value % base_Count)) / base_Count;
                    if (decimal_Value < base_Count) { sexagecimal_Value = Convert.ToInt32(decimal_Value % base_Count) == 0 ? sexagecimal_Value : $"{sexagecimal_Terms[Convert.ToInt32(decimal_Value % base_Count)]}{sexagecimal_Value}"; break; }
                }
                return sexagecimal_Value;

            }
        }

        public static string ConvertToStringBase(Enums.NumerationSystem numerationSystem, IEnumerable<byte> values)
        {
            string value = string.Empty;
            foreach (byte element in values)
            {
                value += ConvertToStringBase(numerationSystem, element);
            }
            return value;
        }
        public static string ConvertToStringBase(Enums.NumerationSystem numerationSystem, IEnumerable<double> values)
        {
            string value = string.Empty;
            foreach (double element in values)
            {
                value += ConvertToStringBase(numerationSystem, element);
            }
            return value;
        }
        public static string ConvertToStringBase(Enums.NumerationSystem numerationSystem, IEnumerable<int> values)
        {
            string value = string.Empty;
            foreach (int element in values)
            {
                value += ConvertToStringBase(numerationSystem, element);
            }
            return value;
        }

        public static string ConvertToStringBase(Enums.NumerationSystem numerationSystem, IEnumerable<byte> values, char splitTerm)
        {
            string value = string.Empty;
            bool first = true;
            foreach (byte element in values)
            {
                if (first)
                {
                    value += ConvertToStringBase(numerationSystem, element);
                    first = false;
                }
                else
                {
                    value += $"{splitTerm}{ConvertToStringBase(numerationSystem, element)}";
                }

            }
            return value;
        }
        public static string ConvertToStringBase(Enums.NumerationSystem numerationSystem, IEnumerable<double> values, char splitTerm)
        {
            string value = string.Empty;
            bool first = true;
            foreach (byte element in values)
            {
                if (first)
                {
                    value += ConvertToStringBase(numerationSystem, element);
                    first = false;
                }
                else
                {
                    value += $"{splitTerm}{ConvertToStringBase(numerationSystem, element)}";
                }

            }
            return value;
        }
        public static string ConvertToStringBase(Enums.NumerationSystem numerationSystem, IEnumerable<int> values, char splitTerm)
        {
            string value = string.Empty;
            bool first = true;
            foreach (byte element in values)
            {
                if (first)
                {
                    value += ConvertToStringBase(numerationSystem, element);
                    first = false;
                }
                else
                {
                    value += $"{splitTerm}{ConvertToStringBase(numerationSystem, element)}";
                }

            }
            return value;
        }

        public static string[] ConvertToStringBaseArray(Enums.NumerationSystem numerationSystem, IEnumerable<byte> values)
        {
            IEnumerable<string> base_Value = new string[] { };
            foreach (var value in values)
            {
                base_Value = base_Value.Append(ConvertToStringBase(numerationSystem, value));
            }
            return (string[])base_Value;
        }
        public static string[] ConvertToStringBaseArray(Enums.NumerationSystem numerationSystem, IEnumerable<double> values)
        {
            IEnumerable<string> base_Value = new string[] { };
            foreach (var value in values)
            {
                base_Value = base_Value.Append(ConvertToStringBase(numerationSystem, value));
            }
            return (string[])base_Value;
        }
        public static string[] ConvertToStringBaseArray(Enums.NumerationSystem numerationSystem, IEnumerable<int> values)
        {
            IEnumerable<string> base_Value = new string[] { };
            foreach (var value in values)
            {
                base_Value = base_Value.Append(ConvertToStringBase(numerationSystem, value));
            }
            return (string[])base_Value;
        }



        public static string ConvertToStringBase(double value, char[] ValuesBase)
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

        public static string ConvertToStringBase(IEnumerable<byte> values, char[] valuesBase)
        {
            string base_Value = string.Empty;
            foreach (byte value in values)
            {
                base_Value += ConvertToStringBase(value, valuesBase);
            }
            return base_Value;
        }
        public static string ConvertToStringBase(IEnumerable<double> values, char[] valuesBase)
        {
            string base_Value = string.Empty;
            foreach (double value in values)
            {
                base_Value += ConvertToStringBase(value, valuesBase);
            }
            return base_Value;
        }
        public static string ConvertToStringBase(IEnumerable<int> values, char[] valuesBase)
        {
            string base_Value = string.Empty;
            foreach (int value in values)
            {
                base_Value += ConvertToStringBase(value, valuesBase);
            }
            return base_Value;
        }

        public static string ConvertToStringBase(IEnumerable<byte> values, char[] valuesBase, char splitTerm)
        {
            string base_Value = string.Empty;
            bool first = true;
            foreach (byte value in values)
            {
                if (first)
                {
                    base_Value += ConvertToStringBase(value, valuesBase);
                    first = false;
                }
                else
                {
                    base_Value += $"{splitTerm}{ConvertToStringBase(value, valuesBase)}";
                }
                base_Value += ConvertToStringBase(value, valuesBase);
            }
            return base_Value;
        }
        public static string ConvertToStringBase(IEnumerable<double> values, char[] valuesBase, char splitTerm)
        {
            string base_Value = string.Empty;
            bool first = true;
            foreach (byte value in values)
            {
                if (first)
                {
                    base_Value += ConvertToStringBase(value, valuesBase);
                    first = false;
                }
                else
                {
                    base_Value += $"{splitTerm}{ConvertToStringBase(value, valuesBase)}";
                }
                base_Value += ConvertToStringBase(value, valuesBase);
            }
            return base_Value;
        }
        public static string ConvertToStringBase(IEnumerable<int> values, char[] valuesBase, char splitTerm)
        {
            string base_Value = string.Empty;
            bool first = true;
            foreach (byte value in values)
            {
                if (first)
                {
                    base_Value += ConvertToStringBase(value, valuesBase);
                    first = false;
                }
                else
                {
                    base_Value += $"{splitTerm}{ConvertToStringBase(value, valuesBase)}";
                }
                base_Value += ConvertToStringBase(value, valuesBase);
            }
            return base_Value;
        }

        public static string[] ConvertToStringBaseArray(IEnumerable<byte> values, char[] valuesBase)
        {
            IEnumerable<string> base_Value = new string[] { };
            foreach (var value in values)
            {
                base_Value = base_Value.Append(ConvertToStringBase(value, valuesBase));
            }
            return (string[])base_Value;
        }
        public static string[] ConvertToStringBaseArray(IEnumerable<double> values, char[] valuesBase)
        {
            IEnumerable<string> base_Value = new string[] { };
            foreach (var value in values)
            {
                base_Value = base_Value.Append(ConvertToStringBase(value, valuesBase));
            }
            return (string[])base_Value;
        }
        public static string[] ConvertToStringBaseArray(IEnumerable<int> values, char[] valuesBase)
        {
            IEnumerable<string> base_Value = new string[] { };
            foreach (var value in values)
            {
                base_Value = base_Value.Append(ConvertToStringBase(value, valuesBase));
            }
            return (string[])base_Value;
        }




        public static double? ConvertToDouble(Enums.NumerationSystem numerationSystem, string value)
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
                List<char> binary_Terms = new List<char>()
                {
                    '0',
                    '1',
                };
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
                List<char> hexadecimal_Terms = new List<char>()
                {
                    '0' ,
                    '1' ,
                    '2' ,
                    '3' ,
                    '4' ,
                    '5' ,
                    '6' ,
                    '7' ,
                    '8' ,
                    '9' ,
                    'A' ,
                    'B' ,
                    'C' ,
                    'D' ,
                    'E' ,
                    'F' ,
                };
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
                List<char> octal_Terms = new List<char>()
                {
                    '0',
                    '1',
                    '2',
                    '3',
                    '4',
                    '5',
                    '6',
                    '7',
                };
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
                List<char> trigecimal_Terms = new List<char>()
                {
                    '0' ,
                    '1' ,
                    '2' ,
                    '3' ,
                    '4' ,
                    '5' ,
                    '6' ,
                    '7' ,
                    '8' ,
                    '9' ,
                    'A' ,
                    'B' ,
                    'C' ,
                    'D' ,
                    'E' ,
                    'F' ,
                    'G' ,
                    'H' ,
                    'I' ,
                    'J' ,
                    'K' ,
                    'L' ,
                    'M' ,
                    'N' ,
                    'O' ,
                    'P' ,
                    'Q' ,
                    'R' ,
                    'S' ,
                    'T' ,
                    'U' ,
                    'V' ,
                    'W' ,
                    'X' ,
                    'Y' ,
                    'Z' ,
                };
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
                List<char> sexagecimal_Terms = new List<char>()
                {
                    '0' ,
                    '1' ,
                    '2' ,
                    '3' ,
                    '4' ,
                    '5' ,
                    '6' ,
                    '7' ,
                    '8' ,
                    '9' ,
                    'a' ,
                    'b' ,
                    'c' ,
                    'd' ,
                    'e' ,
                    'f' ,
                    'g' ,
                    'h' ,
                    'i' ,
                    'j' ,
                    'k' ,
                    'l' ,
                    'm' ,
                    'n' ,
                    'o' ,
                    'p' ,
                    'q' ,
                    'r' ,
                    's' ,
                    't' ,
                    'u' ,
                    'v' ,
                    'w' ,
                    'x' ,
                    'y' ,
                    'z' ,
                    'A' ,
                    'B' ,
                    'C' ,
                    'D' ,
                    'E' ,
                    'F' ,
                    'G' ,
                    'H' ,
                    'I' ,
                    'J' ,
                    'K' ,
                    'L' ,
                    'M' ,
                    'N' ,
                    'O' ,
                    'P' ,
                    'Q' ,
                    'R' ,
                    'S' ,
                    'T' ,
                    'U' ,
                    'V' ,
                    'W' ,
                    'X' ,
                    'Y' ,
                    'Z' ,
                };
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
        public static double[] ConvertToDoubleArray(Enums.NumerationSystem numerationSystem, string[] values)
        {
            IEnumerable<double> double_Value = new double[] { };
            foreach (string value in values)
            {
                double_Value = double_Value.Append(ConvertToDouble(numerationSystem, value).GetValueOrDefault());
            }
            return (double[])double_Value;
        }
        public static double[] ConvertToDoubleArray(Enums.NumerationSystem numerationSystem, string values, char splitTerm)
        {
            IEnumerable<double> double_Value = new double[] { };
            foreach (string value in values.Split(splitTerm))
            {
                double_Value = double_Value.Append(ConvertToDouble(numerationSystem, value).GetValueOrDefault());
            }
            return double_Value.ToArray();
        }


        public static double? ConvertToDouble(string value, char[] valuesBase)
        {
            double base_Value = 0;
            double base_Count = valuesBase.Length;
            double exponent_Count = value.Length;
            foreach (char x in value)
            {
                base_Value += value.IndexOf(x) * Math.Pow(base_Count, exponent_Count);
                exponent_Count--;
            }
            return base_Value;
        }
        public static double[] ConvertToDoubleArray(string[] values, char[] valuesBase)
        {
            IEnumerable<double> double_Value = new double[] { };
            foreach (string value in values)
            {
                double_Value = double_Value.Append(ConvertToDouble(value, valuesBase).GetValueOrDefault());
            }
            return (double[])double_Value;
        }
        public static double[] ConvertToDoubleArray(string values, char[] valuesBase, char splitTerm)
        {
            IEnumerable<double> double_Value = new double[] { };
            foreach (string value in values.Split(splitTerm))
            {
                double_Value = double_Value.Append(ConvertToDouble(value, valuesBase).GetValueOrDefault());
            }
            return (double[])double_Value;
        }



        public static byte? ConvertToByte(Enums.NumerationSystem numerationSystem, string value)
        {
            try
            {
                switch (numerationSystem)
                {
                    case Enums.NumerationSystem.Binary:
                        return Convert.ToByte(ToBinary(value));
                    case Enums.NumerationSystem.Decimal:
                        return Convert.ToByte(Convert.ToDouble(value));
                    case Enums.NumerationSystem.Hexadecimal:
                        return Convert.ToByte(ToHexadecimal(value));
                    case Enums.NumerationSystem.Octal:
                        return Convert.ToByte(ToOctal(value));
                    case Enums.NumerationSystem.Trigecimal:
                        return Convert.ToByte(ToTrigecimal(value));
                    case Enums.NumerationSystem.Sexagecimal:
                        return Convert.ToByte(ToSexagecimal(value));
                    default:
                        return 0;
                }
            }
            catch
            {
                return null;
            }
            double ToBinary(string binary_Value)
            {
                List<char> binary_Terms = new List<char>()
                {
                    '0',
                    '1',
                };
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
                List<char> hexadecimal_Terms = new List<char>()
                {
                    '0' ,
                    '1' ,
                    '2' ,
                    '3' ,
                    '4' ,
                    '5' ,
                    '6' ,
                    '7' ,
                    '8' ,
                    '9' ,
                    'A' ,
                    'B' ,
                    'C' ,
                    'D' ,
                    'E' ,
                    'F' ,
                };
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
                List<char> octal_Terms = new List<char>()
                {
                    '0',
                    '1',
                    '2',
                    '3',
                    '4',
                    '5',
                    '6',
                    '7',
                };
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
                List<char> trigecimal_Terms = new List<char>()
                {
                    '0' ,
                    '1' ,
                    '2' ,
                    '3' ,
                    '4' ,
                    '5' ,
                    '6' ,
                    '7' ,
                    '8' ,
                    '9' ,
                    'A' ,
                    'B' ,
                    'C' ,
                    'D' ,
                    'E' ,
                    'F' ,
                    'G' ,
                    'H' ,
                    'I' ,
                    'J' ,
                    'K' ,
                    'L' ,
                    'M' ,
                    'N' ,
                    'O' ,
                    'P' ,
                    'Q' ,
                    'R' ,
                    'S' ,
                    'T' ,
                    'U' ,
                    'V' ,
                    'W' ,
                    'X' ,
                    'Y' ,
                    'Z' ,
                };
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
                List<char> sexagecimal_Terms = new List<char>()
                {
                    '0' ,
                    '1' ,
                    '2' ,
                    '3' ,
                    '4' ,
                    '5' ,
                    '6' ,
                    '7' ,
                    '8' ,
                    '9' ,
                    'a' ,
                    'b' ,
                    'c' ,
                    'd' ,
                    'e' ,
                    'f' ,
                    'g' ,
                    'h' ,
                    'i' ,
                    'j' ,
                    'k' ,
                    'l' ,
                    'm' ,
                    'n' ,
                    'o' ,
                    'p' ,
                    'q' ,
                    'r' ,
                    's' ,
                    't' ,
                    'u' ,
                    'v' ,
                    'w' ,
                    'x' ,
                    'y' ,
                    'z' ,
                    'A' ,
                    'B' ,
                    'C' ,
                    'D' ,
                    'E' ,
                    'F' ,
                    'G' ,
                    'H' ,
                    'I' ,
                    'J' ,
                    'K' ,
                    'L' ,
                    'M' ,
                    'N' ,
                    'O' ,
                    'P' ,
                    'Q' ,
                    'R' ,
                    'S' ,
                    'T' ,
                    'U' ,
                    'V' ,
                    'W' ,
                    'X' ,
                    'Y' ,
                    'Z' ,
                };
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
        public static byte[] ConvertToByteArray(Enums.NumerationSystem numerationSystem, string[] values)
        {
            IEnumerable<byte> byte_Value = new byte[] { };
            foreach (string value in values)
            {
                byte_Value = byte_Value.Append(ConvertToByte(numerationSystem, value).GetValueOrDefault());
            }
            return byte_Value.ToArray();
        }
        public static byte[] ConvertToByteArray(Enums.NumerationSystem numerationSystem, string values, char splitTerm)
        {
            IEnumerable<byte> byte_Value = new byte[] { };
            foreach (string value in values.Split(splitTerm))
            {
                byte_Value = byte_Value.Append(ConvertToByte(numerationSystem, value).GetValueOrDefault());
            }
            return byte_Value.ToArray();
        }
    }

    public static class Enums
    {
        /// <summary>
        /// Numerations systens where you can choice for convert your value:
        /// <para>Binary: base value 2 (0 and 1)</para>
        /// <para>Octal: base value 8 (0, ..., 7)</para>
        /// <para>Decimal: base value 10 (0, ..., 9)</para>
        /// <para>Hexadecimal: base value 16 (0, ..., F)</para>
        /// <para>Trigecimal: base value 35 (0, ..., 9, A, ..., Z)</para>
        /// <para>Sexagecimal: base value 61 (0, ..., 9,a, ..., z,A, ..., Z)</para>      
        /// <para>Alphabetic: base value 27 (Empty,A, ..., Z)</para>
        /// </summary>
        public enum NumerationSystem
        {
            Binary,
            Octal,
            Decimal,
            Hexadecimal,
            Trigecimal,
            Sexagecimal
        }
    }
}

