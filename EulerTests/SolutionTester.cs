using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolutions;

namespace EulerTests
{
    [TestClass]
    public class SolutionTester
    {
        [TestMethod]
        public void Solution001()
        {
            //Arrange
            var sut = new Solution001();

            //Act
            var result = sut.GetSolutionResult();

            //Assert
        }
    }
}