using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using MyArray1;

namespace MyArrayTests
{
    public class Tests
    {      

        [Test]
        public void Replace_ShouldReplace_IfPositionIsValid()
        {
            //Arange
            var myArray = new MyArray(20);
            //Act
            var result = myArray.Replace(0, 100);
            //Assert
            Assert.IsTrue(result);
            Assert.That(myArray.Array[0], Is.EqualTo(100));
        }
        [Test]
        public void Replace_ShouldThrowsArgumentException_IfPositionIsLessThanZero()
        {
            //Arange
            var myArray = new MyArray(20);
            //Act
            
            //Assert
            
            Assert.Throws<ArgumentException>(()=> myArray.Replace(-2, 20));
        }
        [Test]
        public void Replace_ShouldThrowsArgumentException_IfPositionIsBigerOfArrayLenght()
        {
            //Arange
            var myArray = new MyArray(20);
            //Act & Assert

            Assert.Throws<InvalidOperationException>(() => myArray.Replace(30, 20));
        }
        [Test]
        public void FindMaxArrayLenght_ShouldReturnMaxArrayLenght()
        {
            // Arrange
            var myArray = new MyArray(20);

            // Act
            var result = myArray.FindMax();
            // Assert
            Assert.That(result, Is.EqualTo(19));
        }
        [Test]
        public void FindMaxArrayLenght_ShouldThrowsArgumentException_IfArrayIsEmpty()
        {
            // Arrange
            var myArray = new MyArray(0);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => myArray.FindMax());
        }
    }
}