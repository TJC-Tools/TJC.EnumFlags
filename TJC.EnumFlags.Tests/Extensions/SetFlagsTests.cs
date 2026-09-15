using TJC.EnumFlags.Extensions;
using TJC.EnumFlags.Tests.Mocks;

namespace TJC.EnumFlags.Tests.Extensions
{
    
    public class SetFlagsTests
    {
        [Fact]
        public void NoOptions_GetFlags_Returns0Flags()
        {
            // Arrange
            var flags = (TestEnum)0;

            // Act
            flags.SetFlags([]);
            var result = flags.GetFlags();

            // Assert
            Assert.Equal(0, result.Count());
        }

        [Fact]
        public void SetOption1_GetFlags_Returns1Flag()
        {
            // Arrange
            var flags = TestEnum.Option1;

            // Act
            flags.SetFlags([TestEnum.Option1]);
            var result = flags.GetFlags();

            // Assert
            Assert.Equal(1, result.Count());
            Assert.True(result.Contains(TestEnum.Option1));
        }

        [Fact]
        public void SetOptions1And3_GetFlags_Returns2Flags()
        {
            // Arrange
            var flags = TestEnum.Option1 | TestEnum.Option3;

            // Act
            flags.SetFlags([TestEnum.Option1, TestEnum.Option3]);
            var result = flags.GetFlags();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.True(result.Contains(TestEnum.Option1));
            Assert.False(result.Contains(TestEnum.Option2));
            Assert.True(result.Contains(TestEnum.Option3));
        }
    }
}
