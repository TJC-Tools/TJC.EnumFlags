using TJC.EnumFlags.Extensions;
using TJC.EnumFlags.Tests.Mocks;

namespace TJC.EnumFlags.Tests.Extensions
{
    
    public class GetFlagsTests
    {
        [Fact]
        public void NoOptions_GetFlags_Returns0Flags()
        {
            // Arrange
            var flags = (TestEnum)0;

            // Act
            var result = flags.GetFlags();

            // Assert
            Assert.Equal(0, result.Count());
        }

        [Fact]
        public void Option1_GetFlags_Returns1Flag()
        {
            // Arrange
            var flags = TestEnum.Option1;

            // Act
            var result = flags.GetFlags();

            // Assert
            Assert.Equal(1, result.Count());
            Assert.True(result.Contains(TestEnum.Option1));
        }

        [Fact]
        public void Options1And3_GetFlags_Returns2Flags()
        {
            // Arrange
            var flags = TestEnum.Option1 | TestEnum.Option3;

            // Act
            var result = flags.GetFlags();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.True(result.Contains(TestEnum.Option1));
            Assert.False(result.Contains(TestEnum.Option2));
            Assert.True(result.Contains(TestEnum.Option3));
        }
    }
}
