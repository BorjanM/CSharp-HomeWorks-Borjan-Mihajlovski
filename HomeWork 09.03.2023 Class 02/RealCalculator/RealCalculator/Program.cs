Console.WriteLine("Enter first Number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter secound Number");
int secoundNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("which mathematical operation would you choose  '*', '/', '+', or '-' ?");
int mathOperation = Convert.ToChar(Console.ReadLine());



if (mathOperation == '*')
{
    int result = firstNumber * secoundNumber;
    Console.WriteLine("Your result is" + "" + result);
}
else if (mathOperation == '/')
{
    int result = firstNumber / secoundNumber;
    Console.WriteLine("Your result is" + "" + result);
}
else if (mathOperation == '+')
{
    int result = (firstNumber + secoundNumber);
    Console.WriteLine("Your result is" + "" + result);
}
else if (mathOperation == '-')
{
    int result = (firstNumber - secoundNumber);
    Console.WriteLine("Your result is" + "" + result);
}


