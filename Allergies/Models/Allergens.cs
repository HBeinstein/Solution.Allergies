using System;
using System.Collections.Generic;

namespace Allergens
{
  public class AllergyList
  {
    private Dictionary<int, string> allergenScore = new Dictionary<int, string>() { {1, "eggs"}, {2, "peanuts"}, {4, "shellfish"}, {8, "strawberries"}, {16, "tomatoes"}, {32, "chocolate"}, {64, "pollen"}, {128, "cats"} };
    public bool AllergenScore(int userNum)
    {
      for(int index = 0; index < allergenScore.Count; i++)
      {
        int key = i;
        string value = allergenScore[i]
        
      }
    }
  }
}