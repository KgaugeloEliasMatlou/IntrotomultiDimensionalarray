using System;

class Program
{
    static void HelloMethod()
    {
        Console.WriteLine("Hello world");
    }
    static void ByeMethod()
    {
        Console.WriteLine("Bye world");
    }

    static void Main()
    {

        Console.WriteLine("Enter a word..");
        string word = Console.ReadLine().ToLower();


        if(word == "new")
        {
            HelloMethod();
        }
        else if(word == "old")
        {
            ByeMethod();
        }
        else
        {
            Console.WriteLine(" i dont understand");
        }

        //switch(word)
        //{
        //    case "new":
        //        HelloMethod();
        //        break;
        //    case "old":
        //        ByeMethod();
        //        break;
        //    default:
        //        Console.WriteLine("i dont understand...");
        //        break;

        //}




        //string [,] Multiarray = new string[3,3] { {"x","m","n"}, {"k","T","L"}, {"C","S","B"}};

        //foreach(string s in Multiarray)
        //{
            
        //        Console.Write("{0,50}", s);
        //}

        //for (int y = 0; y < Multiarray.GetLength(0); y++)
        //{
        //    for (int z = 0; z < Multiarray.Rank; z++)
        //    {
        //        Console.WriteLine(Multiarray[y, z]);
        //    }

        //}


        //int[][] intJaggedArray = new int[2][];
        //intJaggedArray[0] = new int[3] { 1, 2, 3 };
        //intJaggedArray[1] = new int[5] {1,2,3,4,5};


    }
}