using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            if (obj1 is null)
            {
                throw new ArgumentNullException(nameof(obj1));
            }

            if (obj2 is null)
            {
                throw new ArgumentNullException(nameof(obj2));
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            if (str is null || str.Length == 0)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            if (str1 is null || str1.Length == 0)
            {
                throw new ArgumentNullException(nameof(str1));
            }

            if (str2 is null || str2.Length == 0)
            {
                throw new ArgumentNullException(nameof(str2));
            }

            return str1 + str2;
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            if (evenNumber % 2 != 0)
            {
                throw new ArgumentException("error", nameof(evenNumber));
            }

            return evenNumber;
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            if (isCandidateWoman)
            {
                if (candidateAge < 16 || candidateAge > 58)
                {
                    throw new ArgumentOutOfRangeException(nameof(candidateAge));
                }
            }
            else
            {
                if (candidateAge < 16 || candidateAge > 63)
                {
                    throw new ArgumentOutOfRangeException(nameof(candidateAge));
                }
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(day));
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month));
            }

            if (username is null || username.Length == 0)
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"{username}-{day}{month}";
        }
    }
}
