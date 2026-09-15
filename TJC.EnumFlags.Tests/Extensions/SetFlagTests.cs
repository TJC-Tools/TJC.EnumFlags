using TJC.EnumFlags.Extensions;
using TJC.EnumFlags.Tests.Mocks;

namespace TJC.EnumFlags.Tests.Extensions
{
    public class SetFlagTests
    {
        [Fact]
        public void NoOptionsSet_CheckForOption1_ReturnsFalse()
        {
            // Arrange
            var flags = (TestEnum)0;

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void SetFlag_Option1_CheckForOption1_ReturnsTrue()
        {
            // Arrange
            var flags = (TestEnum)0;
            flags.SetFlag(TestEnum.Option1);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void SetFlag_Option2_CheckForOption1_ReturnsTrue()
        {
            // Arrange
            var flags = (TestEnum)0;
            flags.SetFlag(TestEnum.Option2);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.False(result);
        }
    }
}
