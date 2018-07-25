using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            // takes string input parses to an in which is an index value and prints the name of student at that value
            // initializing array
            //string[] studentName = { "Jesse", "Chris", "Zac", "Schwartz", "Ash", "Terrell", "Samantha", "Demarko", "Terri", "Patrick", "Drew", "Kristen", "BJ", "Will", "Dr. K", "Jacob" };

                /*List<string> csharpClass = new List<string>();
                csharpClass.Add("1. Jesse"); //first link of chain
                csharpClass.Add("2. Chris"); //second link of chain
                csharpClass.Add("3. Zac"); // link of chain
                csharpClass.Add("4. Schwartz");
                csharpClass.Add("5. Ash");
                csharpClass.Add("6. Terrell");
                csharpClass.Add("7. Samantha");
                csharpClass.Add("8. Demarko");
                csharpClass.Add("9. Terri");
                csharpClass.Add("10. Patrick");
                csharpClass.Add("11. Drew");
                csharpClass.Add("12. Kristen");
                csharpClass.Add("13. BJ");
                csharpClass.Add("14. Will");
                csharpClass.Add("15. Dr. K");
                csharpClass.Add("16. Jacob");*/

            // takes string input parses to an in which is an index value and prints the name of student at that value
                List<string> studentNames = new List<string>();
                //methods (Add method) to start building chain of links of a list
                studentNames.Add("Jesse"); //first link of chain
                studentNames.Add("Chris"); //second link of chain
                studentNames.Add("Zac"); // link of chain
                studentNames.Add("Schwartz");
                studentNames.Add("Ash");
                studentNames.Add("Terrell");
                studentNames.Add("Samantha");
                studentNames.Add("Demarko");
                studentNames.Add("Terri");
                studentNames.Add("Patrick");
                studentNames.Add("Drew");
                studentNames.Add("Kristen");
                studentNames.Add("BJ");
                studentNames.Add("Will");
                studentNames.Add("Dr. K");
                studentNames.Add("Jacob");

                List<string> stuHometown = new List<string>();
                stuHometown.Add("Royal Oak, MI");
                stuHometown.Add("Livonia, MI");
                stuHometown.Add("Wyandotte, MI");
                stuHometown.Add("West Bloomfield, MI");
                stuHometown.Add("Detroit, MI");
                stuHometown.Add("Detroit, MI");
                stuHometown.Add("Clawson, MI");
                stuHometown.Add("Novi, MI");
                stuHometown.Add("Southfield, MI");
                stuHometown.Add("Detroit, MI");
                stuHometown.Add("Detroit, MI");
                stuHometown.Add("Berkley, MI");
                stuHometown.Add("Detroit, MI");
                stuHometown.Add("Farmington Hills, MI");
                stuHometown.Add("Detroit, MI");
                stuHometown.Add("Gary, IN");

                List<string> favFood = new List<string>();
                favFood.Add("pizza");
                favFood.Add("tacos");
                favFood.Add("french fries");
                favFood.Add("cheeseburgers");
                favFood.Add("sushi");
                favFood.Add("salad");
                favFood.Add("chicken shawarma");
                favFood.Add("chicken nuggets");
                favFood.Add("pizza");
                favFood.Add("pulled pork sandwich");
                favFood.Add("tacos");
                favFood.Add("hamburgers");
                favFood.Add("meatloaf");
                favFood.Add("sushi");
                favFood.Add("soup");
                favFood.Add("garlic bread");

            //Console.WriteLine("Student " + {userInput} + " is " + [i] + ". What would you like to know about " + [i] + " ? (enter "hometown" or "favorite food"):");


            int stuNumber;
            string homeOrFood = "";
            string foodInput = "";
            string homeInput = "";

            //shows student option numbers
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number from 1-20)");
            stuNumber = int.Parse(Console.ReadLine()); // takes number converts

            bool userValidation = true;
            while (userValidation) // validates int if it's in range 
            {
                if (stuNumber < 0 || stuNumber >= studentNames.Count) // input int range is over the # of student data true so loop 
                {
                    Console.WriteLine("Sorry! That student doesn't exist. Please try again with a number from (1-20)");
                    stuNumber = int.Parse(Console.ReadLine());
                }
                else // if in range, print this student
                {
                    Console.WriteLine("Student " + stuNumber + " is " + studentNames[stuNumber] + ". What would you like to know about " + studentNames[stuNumber] + "? (enter \"hometown\" or \"favorite food\"):");
                    homeOrFood = Console.ReadLine();
                    userValidation = false; // set to false to leave loop
                }
            }

            // reset bool to continue to next loop 
            userValidation = true;

            while (userValidation)
            {
                if (homeOrFood == "hometown")
                {
                    Console.WriteLine(studentNames[stuNumber] + " is from " + stuHometown[stuNumber] + ". Would you like to know more? Choose \"yes\" or \"no\"");  
                    
                }

                else if (homeOrFood == "favorite food")
                {
                    Console.WriteLine(studentNames[stuNumber] + "'s " + "favorite food is "+ favFood[stuNumber] + ". Would you like to know more? Choose \"yes\" or \"no\""); 
                }

                else
                {
                    Console.WriteLine("Sorry! That data does not exist. Please try again. Enter either \"hometown\" or \"favorite food\":");
                    homeOrFood = Console.ReadLine();
                    userValidation = false;
                }
            }
        }
    }
}
// method to print out a list
/*public static void PrintList(List<string> list)
{
    foreach (string items in list)
    {
        Console.WriteLine(items);
    }
}*/