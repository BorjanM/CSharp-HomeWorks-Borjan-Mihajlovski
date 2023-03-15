Console.WriteLine("Vnesi prv broj");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vnesi vtor broj");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vnesi operacija +, - , *, / .");
char znak = char.Parse(Console.ReadLine());



int Sum(int number, int numberTwo)
{
    return number + numberTwo;
}

int Substract(int number, int numberTwo)
{
    return number - numberTwo;
}

int Devide(int number, int numberTwo)
{
    return number / numberTwo;
}

int Multiply(int number, int numberTwo)
{
    return number * numberTwo;
}



//int Calculator(int number, int numberTwo, int znak)
//{
//    int result = 0;

//    if (znak == '+')
//    {
//        result = Sum(number, numberTwo);
//    }

//    else if (znak == '-')
//    {
//        result = Substract(number, numberTwo);
//    }
//    else if (znak == '*')
//    {
//        result = Multiply(number, numberTwo);
//    }
//    else if (znak == '/')
//    {

//        if (numberTwo == 0)
//        {
//            Console.WriteLine("You cant devide by zero");
//        }

//        else
//        {
//            result = Devide(number, numberTwo);
//        }

//    }
//    return result;
//}
//int result = Calculator(number, numberTwo, znak);
//Console.WriteLine(result);





// With Switch



int Calculator(int number, int numberTwo, int znak)
{
    int result = 0;
    switch (znak)
    {
        case '+':
            result = Sum(number, numberTwo);
            break;
        case '-':
            result = Substract(number, numberTwo);
            break;
        case '*':
            result = Multiply(number, numberTwo);
            break;
        case '/':
            if (numberTwo == 0)
            {
                Console.WriteLine("Error: cannot divide by zero.");
            }
            else
            {
                result = Devide(number, numberTwo);
            }
            break;
        default:
            Console.WriteLine("Try other operation");
            break;
    }
    return result;
}
int result = Calculator(number, numberTwo, znak);
Console.WriteLine(result);





