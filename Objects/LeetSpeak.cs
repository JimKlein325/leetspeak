namespace LeetSpeak
{
  using System.Collections.Generic;
  public class LeetSpeak
  {


    public string Translate(string input)
    {
      char[] inputChars = input.ToCharArray();
      char[] outputChars = inputChars;//new char[inputChars.Length];

      for (int i = 0; i < inputChars.Length; i++)
      {
        if (char.ToLower(inputChars[i]) == 'e')
        {
          outputChars[i] = '3';
        }
        if (char.ToLower(inputChars[i]) == 'o')
        {
          outputChars[i] = '0';
        }
        if (inputChars[i] == 'I')
        {
          outputChars[i] = '1';
        }
        if (i != 0 && inputChars[i-1] != ' ')
        {
          if (char.ToLower(inputChars[i]) == 's')
          {
            outputChars[i] = 'z';
          }
        }
      }
      return string.Join("", outputChars);
    }
  }
}
