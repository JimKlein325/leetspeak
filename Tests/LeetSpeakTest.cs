using Xunit;
using System;

namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void Translate_ForLetterE_3()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("3", testLeetSpeak.Translate("e"));
    }
    [Fact]
    public void Translate_ForLetterO_0()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("0", testLeetSpeak.Translate("o"));
    }
    [Fact]
    public void Translate_ForLetterI_1()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("1", testLeetSpeak.Translate("I"));
    }
    [Fact]
    public void Translate_ForLetterS_z()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      var output = testLeetSpeak.Translate("is");
      Assert.Equal("iz", output);
    }
    [Fact]
    public void Translate_ForFirstLetter_S_S()
    {
      LeetSpeak testLeetSpeak = new LeetSpeak();
      Assert.Equal("Sim0n Sayz", testLeetSpeak.Translate("Simon Says"));
    }
  }
}
