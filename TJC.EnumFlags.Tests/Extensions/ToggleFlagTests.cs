using TJC.EnumFlags.Extensions;
using TJC.EnumFlags.Tests.Mocks;

namespace TJC.EnumFlags.Tests.Extensions
{
    [TestClass]
    public class ToggleFlagTests
    {
        [TestMethod]
        public void ToggleFlag1_CheckForOption1_ReturnsTrue()
        {
            // Arrange
            var flags = (TestEnum)0;
            flags.ToggleFlag(TestEnum.Option1);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToggleFlag1Twice_CheckForOption1_ReturnsFalse()
        {
            // Arrange
            var flags = (TestEnum)0;
            flags.ToggleFlag(TestEnum.Option1);
            flags.ToggleFlag(TestEnum.Option1);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
