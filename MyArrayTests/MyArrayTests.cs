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
            //Act

            //Assert

            Assert.Throws<ArgumentException>(() => myArray.Replace(30, 20));
        }
    }
}