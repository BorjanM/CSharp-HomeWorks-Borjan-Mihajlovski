string[] groupeOne = new string[] { "Borjan", "Slave", "Zhare", "Maja", "Leo" };

string[] groupTwo = new string[] { "Mihajlovski", "Ivanovski", "Ilievski", "Postolova", "Neznam" };


Console.Write("Vnesete broj za da izberete prikaz na studentskite grupi: ");
string izbor = Console.ReadLine();




switch (izbor)
{
    case "1":
        {
            for (int b = 0; b < groupeOne.Length; b++)
            {
                Console.WriteLine(groupeOne[b]);
            }
            break;
        }
    case "2":
        {
            for (int z = 0; z < groupTwo.Length; z++)
            {
                Console.WriteLine(groupTwo[z]);
            }
            break;
        }
    default:
        Console.WriteLine("Try Again");
        break;
}

