// Start Main
DisplayMenu();

//Main

static void DisplayMenu()
{
    Console.WriteLine("Press any number to continue");
    string choice = Console.ReadLine();

    while( choice != "3")
    {
        Console.WriteLine("\n1. Full Triangle \n2. Partial Triangle \n3. Exit");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            GetFull();
        }
        else if (choice == "2")
        {
            GetPartial();
        }
        else if (choice == "3")
        {

        }
        else {
            Console.WriteLine("Invalid");
        }
    }

    
}
 
 static void GetFull()
    {
        int ran = new Random().Next(3,9);

        for (int i = ran; i > 0; i--)
        {
            for (int d = i ; d < ran ; d++)
            {
                Console.Write("0\t");
            }
            Console.WriteLine();
        }
    }

    static void GetPartial()
    {
        int ran = new Random().Next(3,9);

        for (int i = ran; i > 0; i--)
        {
            for (int d = i ; d < ran ; d++)
            {
                if (d == 3 || d == 5 || d == 9)
                {
                    Console.Write("\t");
                }
                Console.Write("0\t");  
            }
            Console.WriteLine();
        }
    }