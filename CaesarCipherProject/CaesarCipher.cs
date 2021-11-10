using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherProject
{
    public static class CaesarCipher
    {
        private const int AlphabetShiftRange = 26;
        private const int LetterValueRangeStart = 65;
        private const int LetterValueRangeEnd = 90;

        public static string Encrypt(string plainText, int shiftKey)
        {
            return ShiftText(plainText, shiftKey);
        }

        public static string Decrypt(string cipherText, int shiftKey)
        {
            return ShiftText(cipherText, -shiftKey);
        }

        private static string ShiftText(string plainText, int shiftKey)
        {
            var shiftedText = string.Empty;

            if (string.IsNullOrEmpty(plainText)) return shiftedText;

            var shiftValue = shiftKey % AlphabetShiftRange;

            plainText.ToUpper()
                .ToCharArray()
                .ToList()
                .ForEach(x =>
                {
                    if (char.IsLetter(x)) shiftedText += ShiftLetter(x, shiftValue);
                    else shiftedText += x;
                });

            return shiftedText;
        }

        private static char ShiftLetter(char letter, int shiftValue)
        {
            var charValue = (int)letter;
            charValue += shiftValue;

            if (charValue > LetterValueRangeEnd)
                charValue = LetterValueRangeStart + charValue - LetterValueRangeEnd - 1;
            else if (charValue < LetterValueRangeStart)
                charValue = LetterValueRangeEnd + charValue - LetterValueRangeStart + 1;

            return (char)charValue;
        }
    }
}
