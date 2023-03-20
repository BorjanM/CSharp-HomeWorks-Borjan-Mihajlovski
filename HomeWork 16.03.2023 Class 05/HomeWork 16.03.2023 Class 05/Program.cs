////Task 1

Console.WriteLine("Enter your string");
string fiveCharacters = Console.ReadLine();
string lastFiveChars = fiveCharacters.Substring(fiveCharacters.Length - 5);
Console.WriteLine(lastFiveChars);

//Task 2
Console.WriteLine("Enter your sentence");
string sentence = Console.ReadLine();
string[] splitSentence = sentence.Split(' ');
foreach (string partOfSentence in splitSentence)
{
    Console.WriteLine(partOfSentence);
}


//Task 3

int calculateSum(int number)
{
    int sumOfNumbers = 0;
    while (number != 0)
    {
        sumOfNumbers += number % 10;
        number /= 10;
    }
    return sumOfNumbers;
}
int resultOfNumbers = calculateSum(55);
Console.WriteLine(resultOfNumbers);



//Task 4

int AgeCalculator(DateTime birthDate)
{
    DateTime now = DateTime.Now;
    int age = now.Year - birthDate.Year;
    if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
    {
        age--;
    }
    return age;
}

DateTime myBirthDate = new DateTime(1992, 04, 19);
int myAge = AgeCalculator(myBirthDate);
Console.WriteLine(myAge);
//poslednava ja resiv so mala pomos na google da si priznaam :) 