using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerlogyCalculator
{
    class Calculator
    {
        public bool AddingAcross { get; set; }

        public int GetLifePathNumber(DateTime dateOfBirth, out bool karmicNumber)
        {
            if (AddingAcross)
            {
                return GetLifePathNumberAddingAcross(dateOfBirth, out karmicNumber);
            }
            else
            {
                return GetLifePathNumberReducingDown(dateOfBirth, out karmicNumber);
            }
        }

        int GetLifePathNumberAddingAcross(DateTime dateOfBirth, out bool karmicNumber)
        {
            int sum = 0;
            int[] digits = GetDigits(dateOfBirth.Day);
            foreach (int digit in digits)
            {
                sum += digit;
            }

            digits = GetDigits(dateOfBirth.Month);
            foreach (int digit in digits)
            {
                sum += digit;
            }

            digits = GetDigits(dateOfBirth.Year);
            foreach (int digit in digits)
            {
                sum += digit;
            }

            karmicNumber = false;

            while (sum >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sum);

                if (sum == 11 || sum == 22 || sum == 33)
                {
                    break;
                }
                else
                {
                    digits = GetDigits(sum);
                    sum = 0;

                    foreach (int digit in digits)
                    {
                        sum += digit;
                    }
                }
            }

            return sum;
        }

        int GetLifePathNumberReducingDown(DateTime dateOfBirth, out bool karmicNumber)
        {
            int sumOfDay = dateOfBirth.Day;
            while (sumOfDay >= 10)
            {
                if (sumOfDay == 11 || sumOfDay == 22 || sumOfDay == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sumOfDay);
                    sumOfDay = 0;

                    foreach (int digit in digits)
                    {
                        sumOfDay += digit;
                    }
                }
            }

            int sumOfMonth = dateOfBirth.Month;
            while (sumOfMonth >= 10)
            {
                if (sumOfMonth == 11 || sumOfMonth == 22 || sumOfMonth == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sumOfMonth);
                    sumOfMonth = 0;

                    foreach (int digit in digits)
                    {
                        sumOfMonth += digit;
                    }
                }
            }

            int sumOfYear = dateOfBirth.Year;
            while (sumOfYear >= 10)
            {
                if (sumOfYear == 11 || sumOfYear == 22 || sumOfYear == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sumOfYear);
                    sumOfYear = 0;

                    foreach (int digit in digits)
                    {
                        sumOfYear += digit;
                    }
                }
            }

            karmicNumber = false;

            int sum = sumOfDay + sumOfMonth + sumOfYear;
            while (sum >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sum);

                if (sum == 11 || sum == 22 || sum == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sum);
                    sum = 0;

                    foreach (int digit in digits)
                    {
                        sum += digit;
                    }
                }
            }

            return sum;
        }

        public int GetDestinyNumber(string nameAtBirth, out bool karmicNumber)
        {
            int sum = 0;
            string[] parts = nameAtBirth.Split(new char[] { ' ' });
            foreach (string part in parts)
            {
                int sumOfPart = 0;
                int[] digits = GetDigits(part);
                foreach (int digit in digits)
                {
                    sumOfPart += digit;
                }

                while (sumOfPart >= 10)
                {
                    if (sumOfPart == 11 || sumOfPart == 22 || sumOfPart == 33)
                    {
                        break;
                    }
                    else
                    {
                        digits = GetDigits(sumOfPart);
                        sumOfPart = 0;

                        foreach (int digit in digits)
                        {
                            sumOfPart += digit;
                        }
                    }
                }

                sum += sumOfPart;
            }

            karmicNumber = false;

            while (sum >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sum);

                if (sum == 11 || sum == 22 || sum == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sum);
                    sum = 0;

                    foreach (int digit in digits)
                    {
                        sum += digit;
                    }
                }
            }

            return sum;
        }

        public int GetSoulNumber(string nameAtBirth, out bool karmicNumber)
        {
            int sum = 0;
            string[] parts = nameAtBirth.Split(new char[] { ' ' });
            foreach (string part in parts)
            {
                int sumOfPart = 0;
                char[] vowels = GetVowels(part);
                foreach (char vowel in vowels)
                {
                    sumOfPart += GetDigitForAlphabet(vowel);
                }

                while (sumOfPart >= 10)
                {
                    if (sumOfPart == 11 || sumOfPart == 22 || sumOfPart == 33)
                    {
                        break;
                    }
                    else
                    {
                        int[] digits = GetDigits(sumOfPart);
                        sumOfPart = 0;

                        foreach (int digit in digits)
                        {
                            sumOfPart += digit;
                        }
                    }
                }

                sum += sumOfPart;
            }

            karmicNumber = false;

            while (sum >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sum);

                if (sum == 11 || sum == 22 || sum == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sum);
                    sum = 0;

                    foreach (int digit in digits)
                    {
                        sum += digit;
                    }
                }
            }

            return sum;
        }

        public int GetPersonalityNumber(string nameAtBirth, out bool karmicNumber)
        {
            int sum = 0;
            string[] parts = nameAtBirth.Split(new char[] { ' ' });
            foreach (string part in parts)
            {
                int sumOfPart = 0;
                char[] consonents = GetConsonents(part);
                foreach (char consonent in consonents)
                {
                    sumOfPart += GetDigitForAlphabet(consonent);
                }

                while (sumOfPart >= 10)
                {
                    if (sumOfPart == 11 || sumOfPart == 22 || sumOfPart == 33)
                    {
                        break;
                    }
                    else
                    {
                        int[] digits = GetDigits(sumOfPart);
                        sumOfPart = 0;

                        foreach (int digit in digits)
                        {
                            sumOfPart += digit;
                        }
                    }
                }

                sum += sumOfPart;
            }

            karmicNumber = false;

            while (sum >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sum);

                if (sum == 11 || sum == 22 || sum == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sum);
                    sum = 0;

                    foreach (int digit in digits)
                    {
                        sum += digit;
                    }
                }
            }

            return sum;
        }

        public int GetMaturityNumber(DateTime dateOfBirth, string nameAtBirth, out bool karmicNumber)
        {
            int sum = GetLifePathNumber(dateOfBirth, out karmicNumber) + GetDestinyNumber(nameAtBirth, out karmicNumber);

            karmicNumber = false;

            while (sum >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sum);

                if (sum == 11 || sum == 22 || sum == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sum);
                    sum = 0;

                    foreach (int digit in digits)
                    {
                        sum += digit;
                    }
                }
            }

            return sum;
        }

        public int GetCurrentNameNumber(string currentName, out bool karmicNumber)
        {
            int sum = 0;
            string[] parts = currentName.Split(new char[] { ' ' });
            foreach (string part in parts)
            {
                int sumOfPart = 0;
                int[] digits = GetDigits(part);
                foreach (int digit in digits)
                {
                    sumOfPart += digit;
                }

                while (sumOfPart >= 10)
                {
                    if (sumOfPart == 11 || sumOfPart == 22 || sumOfPart == 33)
                    {
                        break;
                    }
                    else
                    {
                        digits = GetDigits(sumOfPart);
                        sumOfPart = 0;

                        foreach (int digit in digits)
                        {
                            sumOfPart += digit;
                        }
                    }
                }

                sum += sumOfPart;
            }

            karmicNumber = false;

            while (sum >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sum);

                if (sum == 11 || sum == 22 || sum == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sum);
                    sum = 0;

                    foreach (int digit in digits)
                    {
                        sum += digit;
                    }
                }
            }

            return sum;
        }

        public int GetBirthDayNumber(DateTime dateOfBirth, out bool karmicNumber)
        {
            int sumOfDay = dateOfBirth.Day;

            karmicNumber = false;

            while (sumOfDay >= 10)
            {
                karmicNumber = IsKarmicDebtNumber(sumOfDay);

                if (sumOfDay == 11 || sumOfDay == 22 || sumOfDay == 33)
                {
                    break;
                }
                else
                {
                    int[] digits = GetDigits(sumOfDay);
                    sumOfDay = 0;

                    foreach (int digit in digits)
                    {
                        sumOfDay += digit;
                    }
                }
            }

            return sumOfDay;
        }

        public List<int> GetKarmicLessonNumber(string nameAtBirth)
        {
            List<int> result = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (char alphabet in nameAtBirth)
            {
                int number = GetDigitForAlphabet(alphabet);
                result.Remove(number);
            }

            return result;
        }

        bool IsKarmicDebtNumber(int number)
        {
            switch (number)
            {
                case 13:
                case 14:
                case 16:
                case 19:
                    return true;

                default:
                    return false;
            }
        }

        int[] GetDigits(int number)
        {
            List<int> digits = new List<int>();
            while (number > 0)
            {
                int digit = number % 10;
                number = (number - digit) / 10;

                if (digit != 0)
                {
                    digits.Add(digit);
                }
            }

            return digits.ToArray();
        }

        int[] GetDigits(string name)
        {
            List<int> digits = new List<int>();
            foreach (char alphabet in name)
            {
                int number = GetDigitForAlphabet(alphabet);
                if (number > 0)
                {
                    digits.Add(number);
                }
            }

            return digits.ToArray();
        }

        char[] GetVowels(string name)
        {
            List<char> vowels = new List<char>();
            for (int i = 0; i < name.Length; i++)
            {
                if ((i == 0 && name[i] == 'Y') &&
                    ((i + 1) < name.Length && !IsVowel(name[i + 1])))
                {
                    vowels.Add(name[i]);
                }
                else if ((i == name.Length - 1 && name[i] == 'Y') &&
                         ((i - 1) >= 0 && !IsVowel(name[i - 1])))
                {
                    vowels.Add(name[i]);
                }
                else if ((name[i] == 'Y') &&
                         ((i - 1) >= 0 && !IsVowel(name[i - 1])) &&
                         ((i + 1) < name.Length && !IsVowel(name[i + 1])))
                {
                    vowels.Add(name[i]);
                }
                else if (IsVowel(name[i]))
                {
                    vowels.Add(name[i]);
                }
            }

            return vowels.ToArray();
        }

        char[] GetConsonents(string name)
        {
            List<char> consonents = new List<char>();
            for (int i = 0; i < name.Length; i++)
            {
                if ((i == 0 && name[i] == 'Y') &&
                    ((i + 1) < name.Length && IsVowel(name[i + 1])))
                {
                    consonents.Add(name[i]);
                }
                else if ((i == name.Length - 1 && name[i] == 'Y') &&
                         ((i - 1) >= 0 && IsVowel(name[i - 1])))
                {
                    consonents.Add(name[i]);
                }
                else if ((name[i] == 'Y') &&
                         (((i - 1) >= 0 && IsVowel(name[i - 1])) ||
                          ((i + 1) < name.Length && IsVowel(name[i + 1]))))
                {
                    consonents.Add(name[i]);
                }
                else if (!IsVowel(name[i]))
                {
                    consonents.Add(name[i]);
                }
            }

            return consonents.ToArray();
        }

        bool IsVowel(char alphabet)
        {
            switch (alphabet)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    return true;

                default:
                    return false;
            }
        }

        int GetDigitForAlphabet(char alphabet)
        {
            if (char.IsLetter(alphabet))
            {
                int charValue = alphabet - (int)'A';
                return (charValue % 9) + 1;
            }

            return 0;
        }
    }
}
