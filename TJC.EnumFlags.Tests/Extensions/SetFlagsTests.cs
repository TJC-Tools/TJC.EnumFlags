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
            Assert.Empty(result);
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
            Assert.Single(result);
            Assert.Contains(TestEnum.Option1, result);
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
            Assert.Contains(TestEnum.Option1, result);
            Assert.DoesNotContain(TestEnum.Option2, result);
            Assert.Contains(TestEnum.Option3, result);
        }
    }
}
