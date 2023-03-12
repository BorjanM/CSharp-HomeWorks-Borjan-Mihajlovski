
int[] myArray = new int[6];
int evenArray = 0;



Console.Write("Enter your first number: ");
int prv = Convert.ToInt32(Console.ReadLine());
myArray[0] = prv;

Console.Write("Enter your secound number: ");
int vtor = Convert.ToInt32(Console.ReadLine());
myArray[1] = vtor;

Console.Write("Enter your third number: ");
int tret = Convert.ToInt32(Console.ReadLine());
myArray[2] = tret;

Console.Write("Enter your fourth number: ");
int fourth = Convert.ToInt32(Console.ReadLine());
myArray[3] = fourth;

Console.Write("Enter your secound number: ");
int fifth = Convert.ToInt32(Console.ReadLine());
myArray[4] = fifth;

Console.Write("Enter your secound number: ");
int sixth = Convert.ToInt32(Console.ReadLine());
myArray[5] = sixth;


for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0)
    {
        evenArray += myArray[i];
    }
}
Console.WriteLine("Even numbers sum is " + evenArray);
