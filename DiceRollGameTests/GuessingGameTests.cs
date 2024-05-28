using DiceRollGame.Game;
using DiceRollGame.UserCommunication;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiceRollGameTests
{
    [TestFixture]
    public class GuessingGameTests
    {
        private Mock<IDice> _diceMock;
        private Mock<IUserCommunication> _userCommunication;
        private GuessingGame _cut;

        [SetUp]
        public void SetUp()
        {
            _diceMock = new Mock<IDice>();
            _userCommunication = new Mock<IUserCommunication>();
            _cut = new GuessingGame(_diceMock.Object, _userCommunication.Object);
        }

        [Test]
        public void Play_ShallReturnVictory_IfTheUserGuessesTheNumberOnTheFirstTry()
        {
            
            const int NumberOnDie = 3;
            _diceMock.Setup(mock => mock.Roll()).Returns(NumberOnDie);
            _userCommunication.Setup(mock => mock.ReadInteger(It.IsAny<string>())).Returns(NumberOnDie);
            
            var gameResult = _cut.Play();

            Assert.AreEqual(GameResult.Victory, gameResult);
        }

        [Test]
        public void Play_ShallReturnLoss_IfTheUserNeverGuessesTheNumber()
        {

            const int NumberOnDie = 3;
            _diceMock.Setup(mock => mock.Roll()).Returns(NumberOnDie);
            const int UserNumber = 1;
            _userCommunication.Setup(mock => mock.ReadInteger(It.IsAny<string>())).Returns(UserNumber);

            var gameResult = _cut.Play();

            Assert.AreEqual(GameResult.Loss, gameResult);
        }

        [Test]
        public void Play_ShallReturnVictory_IfTheUserGuessesTheNumberOnTheThirdTry()
        {

            SetupUserGuessingTheNumberOnTheThirdTry();

            var gameResult = _cut.Play();

            Assert.AreEqual(GameResult.Victory, gameResult);
        }

        [Test]
        public void Play_ShallReturnLoss_IfTheUserGuessesTheNumberOnTheFourthTry()
        {

            const int NumberOnDie = 3;
            _diceMock.Setup(mock => mock.Roll()).Returns(NumberOnDie);
            _userCommunication.SetupSequence(mock => mock.ReadInteger(It.IsAny<string>()))
                .Returns(1)
                .Returns(2)
                .Returns(5)
                .Returns(NumberOnDie);

            var gameResult = _cut.Play();

            Assert.AreEqual(GameResult.Loss, gameResult);
        }

        [TestCase(GameResult.Victory, "You win!")]
        [TestCase(GameResult.Loss, "You lose :(")]
        public void PrintResult_ShallShowProperMessageForGameResult(GameResult gameResult, string expectecMessage) 
        {
            _cut.PrintResult(gameResult);

            _userCommunication.Verify(mock => mock.ShowMessage(expectecMessage));
        }

        [Test]
        public void Play_ShallShowWelcomeMessage()
        {
            var gameResult = _cut.Play();

            _userCommunication.Verify(mock => mock.ShowMessage("Dice rolled. Guess what number it shows in 3 tries"), Times.Once());
        }

        [Test]
        public void Play_ShallAskForNumberThreeTimes_IfTheUserGuessesTheNumberOnTheThirdTry()
        {
            SetupUserGuessingTheNumberOnTheThirdTry();

            var gameResult = _cut.Play();

            _userCommunication.Verify(mock => mock.ReadInteger("Enter a number:"), Times.Exactly(3));
        }

        [Test]
        public void Play_ShallShowWrongNumberTwice_IfTheUserGuessesTheNumberOnTheThirdTry()
        {
            SetupUserGuessingTheNumberOnTheThirdTry();
            var gameResult = _cut.Play();

            _userCommunication.Verify(mock => mock.ShowMessage("Wrong number."), Times.Exactly(2));
        }

        private void SetupUserGuessingTheNumberOnTheThirdTry()
        {
            const int NumberOnDie = 3;
            _diceMock.Setup(mock => mock.Roll()).Returns(NumberOnDie);
            _userCommunication.SetupSequence(mock => mock.ReadInteger(It.IsAny<string>()))
                .Returns(1)
                .Returns(2)
                .Returns(NumberOnDie);
        }
    }
}
