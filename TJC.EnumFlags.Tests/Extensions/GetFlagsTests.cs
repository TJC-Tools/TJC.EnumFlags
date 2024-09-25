using TJC.EnumFlags.Extensions;
using TJC.EnumFlags.Tests.Mocks;

namespace TJC.EnumFlags.Tests.Extensions
{
    [TestClass]
    public class GetFlagsTests
    {
        [TestMethod]
        public void NoOptions_GetFlags_Returns0Flags()
        {
            // Arrange
            var flags = (TestEnum)0;

            // Act
            var result = flags.GetFlags();

            // Assert
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void Option1_GetFlags_Returns1Flag()
        {
            // Arrange
            var flags = TestEnum.Option1;

            // Act
            var result = flags.GetFlags();

            // Assert
            Assert.AreEqual(1, result.Count());
            Assert.IsTrue(result.Contains(TestEnum.Option1));
        }

        [TestMethod]
        public void Options1And3_GetFlags_Returns2Flags()
        {
            // Arrange
            var flags = TestEnum.Option1 | TestEnum.Option3;

            // Act
            var result = flags.GetFlags();

            // Assert
            Assert.AreEqual(2, result.Count());
            Assert.IsTrue(result.Contains(TestEnum.Option1));
            Assert.IsFalse(result.Contains(TestEnum.Option2));
            Assert.IsTrue(result.Contains(TestEnum.Option3));
        }
    }
}