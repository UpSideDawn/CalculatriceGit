//using Services.Services;

//namespace Services.Tests
//{
//    public class OperationBasiqueTests
//    {
//        private OperationBasiqueService _operationBasiqueService;

//        public OperationBasiqueTests()
//        {
//        //    _operationBasiqueService = new OperationBasiqueService();
//        }

//        [Theory]
//        [InlineData(9.0, 3.5, 12.5 )]      // Insère des données en paramètres de la fonction TestAddition
//        [InlineData(9.0, 5.0, 14.0 )]
//        [InlineData(9.0, 2.0, 11.0)]
//        [InlineData(9.0, 7.0, 16.0 )]
        
//        public void TestAdditionShouldBeEqual(double number1, double number2, double expectedResult)
//        {                

//            var actual = _operationBasiqueService.Addition(number1, number2);

//            Assert.Equal(expectedResult, actual);
            
//        }

//        [Theory]
//        [InlineData(1.0, 2.0, 8.0)]
//        public void TestAdditionShouldNotBeEqual(double number1, double number2, double expectedResult)
//        {
         
//            var actual = _operationBasiqueService.Addition(number1, number2);

//            Assert.NotEqual(expectedResult, actual);

//        }

//        [Theory]
//        [InlineData(2.0, 6.0, 12.0)]
//        [InlineData(3.0, 6.0, 18.0)]
//        public void TestMultiplicationShouldBeEqual(double number1, double number2, double expectedResult)
//        {

//            var actual = _operationBasiqueService.Multiplication(number1, number2);

//            Assert.Equal(expectedResult, actual);
//        }
//        [Theory]
//        [InlineData(2.0, 6.0, 11.0)]
//        [InlineData(50.0, 30.0, 18.0)]
//        public void TestMultiplicationShouldNotBeEqual(double number1, double number2, double expectedResult)
//        {

//            var actual = _operationBasiqueService.Multiplication(number1, number2);

//            Assert.NotEqual(expectedResult, actual);
//        }
//        [Theory]
//        [InlineData(2.0, 6.0, 6.0, 6.0, 11.0)]
//        [InlineData(5.0, 3.0, 3.0, 3.0, 14.0)]
//        public void TestComplexeOperationShouldBeEqual(double number1, double number2, double number3, double number4, double expectedResult)
//        {
//            var actual1Calc = _operationBasiqueService.Addition(number1, number2);
//            var actual2Calc = _operationBasiqueService.Addition(number3, number4);
//            var actual = _operationBasiqueService.Addition(actual1Calc, actual2Calc);

//            Assert.Equal(expectedResult, actual);
//        }
//    }



    
//}
