using bussiness.Helpers;
namespace Test.Helpers;

public class IdGenerator_Test
{
[Fact]
public void Generate_ShouldReturnGuidAsString() 
{
    // act
    var result = IdGenerator.Generate();

    // assert
    Assert.NotNull(result);
    Assert.True(Guid.TryParse(result, out _));
}
}
