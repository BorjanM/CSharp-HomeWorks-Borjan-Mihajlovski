Console.WriteLine("Enter your first Number");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your secound Number");
int secoundNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your first number is" + " " + firstNum);
Console.WriteLine("Your secound number is" + " " + secoundNum);

int nov = firstNum;
firstNum = secoundNum;
secoundNum = nov;
Console.WriteLine("posle promena prv broj e " + firstNum);
Console.WriteLine("posle promena vtor broj e " + secoundNum);

