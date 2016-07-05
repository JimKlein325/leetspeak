namespace LeetSpeak
{
  using System;
  using System.Collections.Generic;
  using System.Text;


  public class Allergy
  {
    private string _name;
    private static List<Allergy> _allergies = new List<Allergy> {};

    public Allergy(string name)
    {
      _name = name;
      _allergies.Add(this);
    }
    public string GetName(){
      return _name;
    }
    public List<Allergy> GetAll()
    {
      return _allergies;
    }
    public static void ClearAll(){
      _allergies.Clear();
    }
    public static string GetAllergyListString ()
    {
      StringBuilder allergyString = new StringBuilder();
      List<string> allergies = new List<string>{};
      foreach(Allergy allergy in _allergies)
      {
        allergies.Add(allergy.GetName());
      }
      for(int i = 0 ; i < allergies.Count-1 ; i++)
      {
        allergyString.Append(allergies[i] + ", ");
      }
      allergyString.Append(allergies[allergies.Count-1]);

      return allergyString.ToString();
    }
  }

  public class Allergies
  {

    public string UncodeAllergyScore(int score)
    {
      RemoveLargestAllergy(score);
      return Allergy.GetAllergyListString();
    }

    public int RemoveLargestAllergy(int input)
    {
      if( input >= 128 )
      {
        int CatRemainder = input - 128;
        Allergy allergy = new Allergy("Cat");
        if(CatRemainder > 0) RemoveLargestAllergy(CatRemainder);
        return CatRemainder;
      }
      if( input >= 64 )
      {
        int PollenRemainder = input - 64;
        Allergy allergy = new Allergy("Pollen");
        if(PollenRemainder > 0) RemoveLargestAllergy(PollenRemainder);
        Console.WriteLine("Pollen " + PollenRemainder);
        return PollenRemainder;
      }
      Console.WriteLine("Ending method " + input);
      return input;
    }
  }
}
