using System;
using Arrays_and_Lists;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hussein Hussein - 103615588
            // Arrays

            // Declare variable name
        //    string[] names = new string[5];
       //     // Create array of names
      //      names[0] = "Olofmeister";
       //     names[1] = "Zywoo";
      //      names[2] = "Hussein";
     //       names[3] = "Fraicheville";
      //      names[4] = "Patrick";

     //       foreach(string name in names)
     //       Console.WriteLine("Hello " + name);

          //  Exercise 2 - Use of Arrays

    //       Console.WriteLine("____________________________________________");
    //       Console.WriteLine("              Exercise 2                    ");

    //    int[] mafs = new int[10] {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};

     //   int sum = 0;

     //   Array.ForEach(mafs, i => sum += i);
     //   Console.WriteLine(sum);
     //   Console.WriteLine("____________________________________________");
        // _______________________________________________________________________________ //
     //   Console.WriteLine();
    //    Console.WriteLine("Lists and their use!");
    //    Console.WriteLine("____________________"); 

        // Exercise 1
     //   List<int> newnumbers = new List<int>();
     //   Console.WriteLine("Insert 5 numbers: ");
    //    newnumbers.Add (int.Parse(Console.ReadLine()));
     //   newnumbers.Add (int.Parse(Console.ReadLine()));
     //   newnumbers.Add (int.Parse(Console.ReadLine()));
     //   newnumbers.Add (int.Parse(Console.ReadLine()));
     //   newnumbers.Add (int.Parse(Console.ReadLine()));

     //  Console.WriteLine("Insert Another Number: ");
     //   int Input = int.Parse(Console.ReadLine());
       //     if (newnumbers.Contains(Input))
      //      {
       //         Console.WriteLine("This number has already been inputted. ");
       //     }
     //       else
      //      {
       //         Console.WriteLine("This number hasn't already been inputted. ");


         //  Console.WriteLine("____________________________________________");
         //  Console.WriteLine("                   Task 2                   ");  

      //     List<int> newNumb = new List<int>();
	//		HashSet<int> uniqueNumbers = new HashSet<int>();
     //       Dictionary<int, int> numberDict = new Dictionary<int, int>();

	//		Console.WriteLine("Please enter five numbers");
		//	for (int i = 1; i <= 5; i++)
		//	{
		//		int number = int.Parse(Console.ReadLine());
	//			newNumb.Add(number);
		//		uniqueNumbers.Add(number);
		//	}


        //    Console.WriteLine("Numbers");
      //      foreach (int num in newNumb)
      //      {
       //         if (uniqueNumbers.Contains(num))
       //         {
      //              if (!numberDict.ContainsKey(num))
       //             {
       //                 numberDict.Add(num, 1);
       //             }
       //             else
       //             {
       //                 numberDict[num] = numberDict[num] + 1;
      //              }
     //           }
       //     }

      //      foreach(KeyValuePair<int, int> kvp in numberDict)
      //      {
       //         Console.WriteLine("{0} repeats {1} times", kvp.Key, kvp.Value);
      //      }

        Console.WriteLine("____________________________________________");
        Console.WriteLine("                   Task 3                   ");   

             Console.WriteLine("Input words of your choice then type stop: ");

                List<string> inputWordz = new List<string>();
                bool passcode = false;
                 while (!passcode) 
                 {
                    string word = Console.ReadLine();

                    if (word == "stop")
                    {
                        passcode = true;
                    }
                    inputWordz.Add(word);
                 }
                inputWordz.Reverse();

                Console.WriteLine();
                foreach (string word in inputWordz) 
                {
                  Console.WriteLine(word);
                }
              

        }
    }
}

