using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPhrase
{
    class Program
    {
        static void Main(string[] args)
        {
            //create several random phrase--one will be displayed when the program is executed
            //get a random number based on the number of phraes we use. (Why?)
            //select the phrase based on the number that was randomly generated
            //print random phrase to screen.

            

            {
                string playAgain = "N";
                string[] responses = { "MC is the Best!", "MC will be famous!", "Lexus is the Greatest Manager EVER" };
                var max = responses.Length; //this gets length of array. 3
                                            //max has a value of 3.
                Random random = new Random(); //instantiate (create) random object.
                                              // select random number from 0 to max -1.
                                              //easy way to do this!
                do
                {
                    Console.WriteLine("Enter a question.");
                    Console.ReadLine();

                    var selectedNum = random.Next(max);
                    //use selectedNum as index in the array
                    //and write it to the console.
                    Console.WriteLine(responses[selectedNum]);
                    Console.WriteLine("Would you like to play again (Y or N)?");
                    playAgain = Console.ReadLine();

                }
                while (playAgain == "Y");
                
                    
                

            }

        }
    }
}
