using Xunit;
using System;

namespace LeetSpeak
{
  public class AllergyTest : IDisposable
  {
    [Fact]
    public void RemoveLargestAllergy_ForCat_0()
    {
      //Arrange
      Allergies testAllergies = new Allergies();

      //Act
      int remainder = testAllergies.RemoveLargestAllergy(128);
      // string name = Allergy.GetAllergyListString();

      //Assert
      Assert.Equal(0, remainder);
    }
    [Fact]
    public void UncodeAllergyScore_ForScore128_Cat()
    {
      //Arrange
      Allergies testAllergies = new Allergies();

      //Act
      string name = testAllergies.UncodeAllergyScore(128);

      //Assert
      Assert.Equal("Cat", name);
    }
    [Fact]
    public void RemoveLargestAllergy_ForCat_127()
    {
      //Arrange
      Allergies testAllergies = new Allergies();

      //Act
      int remainder = testAllergies.RemoveLargestAllergy(255);
      Console.WriteLine("Remainder is " + remainder);
      // string name = Allergy.GetAllergyListString();

      //Assert
      Assert.Equal(127, remainder);
    }

    public void Dispose()
    {
      Allergy.ClearAll();
    }
  }
}
