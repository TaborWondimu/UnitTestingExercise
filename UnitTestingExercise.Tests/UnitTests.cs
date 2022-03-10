using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData (4,4,4, 12)]
        [InlineData (-1,-2,-2,-5)]
        [InlineData (0,0,0,0)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calc = new Calculator();



            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calc.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData (0,0,0)]
        [InlineData (-5,5,-10)]
        [InlineData (null,0,0)]
        [InlineData (null,null,null)]
        //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calc = new Calculator();


            //Act
            var actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }
       
        [Theory]
        [InlineData(0,0,0)]
        [InlineData (-5,-5,25)]
        [InlineData (10,0,0)]
        [InlineData(10,-5,-50)]
        [InlineData(null,5,0)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calc = new Calculator();

            //Act
           var actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0,5,0)]
        [InlineData(10,2,5)]
        [InlineData(null,5,0)]
        [InlineData(10,10,1)]
        [InlineData(45,45,1)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();
            //Act
            var actual = calc.Divide(num1, num2);
            //Assert
            Assert.Equal(expected,actual);
        }

    }
}
