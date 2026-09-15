using TJC.EnumFlags.Extensions;
using TJC.EnumFlags.Tests.Mocks;

namespace TJC.EnumFlags.Tests.Extensions
{
    public class ClearFlagTests
    {
        [Fact]
        public void Option1_CheckForOption1_ReturnsTrue()
        {
            // Arrange
            var flags = TestEnum.Option1;

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Option1_ClearFlagOption1_CheckForOption1_ReturnsFalse()
        {
            // Arrange
            var flags = TestEnum.Option1;
            flags.ClearFlag(TestEnum.Option1);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Option1And2_ClearFlagOption2_CheckForOption1_ReturnsFalse()
        {
            // Arrange
            var flags = TestEnum.Option1 | TestEnum.Option2;
            flags.ClearFlag(TestEnum.Option1);

            // Act
            var result = flags.HasFlag(TestEnum.Option1);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Option1And2_ClearFlagOption2_CheckForOption2_ReturnsTrue()
        {
            // Arrange
            var flags = TestEnum.Option1 | TestEnum.Option2;
            flags.ClearFlag(TestEnum.Option1);

            // Act
            var result = flags.HasFlag(TestEnum.Option2);

            // Assert
            Assert.True(result);
        }
    }
}
