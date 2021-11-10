using System;
using Xunit;

namespace CaesarCipherProject.Tests
{
    public class CaesarCipherUnitTests
    {
        [Fact]
        public void Caesar_cipher_encryption_test()
        {
            var expected = "QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD";
            var shiftKey = -3;
            var plainText = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";

            var actual = CaesarCipher.Encrypt(plainText, shiftKey);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Caesar_cipher_decryption_test()
        {
            var expected = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            var shiftKey = -3;
            var cipherText = "QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD";

            var actual = CaesarCipher.Decrypt(cipherText, shiftKey);

            Assert.Equal(expected, actual);
        }
    }
}
