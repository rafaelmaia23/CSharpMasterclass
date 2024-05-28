using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorTests
{
    [TestFixture]
    public class PasswordGeneratorTests
    {
        private Mock<IRandom> _randomMock;
        private PasswordGenerator _cut;

        [SetUp]
        public void SetUp()
        {
            _randomMock = new Mock<IRandom>();
            _cut = new PasswordGenerator(_randomMock.Object);
        }

        [TestCase(3)]
        [TestCase(5)]
        [TestCase(8)]
        public void Generate_ShallReturnPasswordOfRigthLengthForInput(int passwordLength)
        {
            _randomMock.Setup(mock => mock.Random.Next()).Returns(passwordLength);
            const int minPasswordLength = 1;
            const int maxPasswordLength = 10;
            const bool useSpecialCharacthers = false;

            var result = _cut.Generate(minPasswordLength, maxPasswordLength, useSpecialCharacthers);

            Assert.AreEqual(passwordLength, result.Length);
        }

    }
}
