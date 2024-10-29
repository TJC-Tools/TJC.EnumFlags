using TJC.EnumFlags.Extensions;
using TJC.EnumFlags.Tests.Mocks;

namespace TJC.EnumFlags.Tests.Extensions
{
    [TestClass]
    public class SetFlagTests
    {
        [TestMethod]
        public void NoOptionsSet_CheckForOption1_ReturnsFalse()
        {
            // Arrange
            var flags = (TestEnum)0;

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SetFlag_Option1_CheckForOption1_ReturnsTrue()
        {
            // Arrange
            var flags = (TestEnum)0;
            flags.SetFlag(TestEnum.Option1);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SetFlag_Option2_CheckForOption1_ReturnsTrue()
        {
            // Arrange
            var flags = (TestEnum)0;
            flags.SetFlag(TestEnum.Option2);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
