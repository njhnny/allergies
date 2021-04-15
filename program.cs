using System;

class AllergyClass
{
  static void Main()
  {
    Console.WriteLine("Enter your allergy score");
    int allergyScore = Console.ReadLine();
    ScoreBreaker objectName = new ScoreBreaker();
    outputList = objectName.someFunction(enteredScore);
    Allergy objectName2 = new Allergy();
    outputList2 = objectName2.someFunction(outputList);
  }
}