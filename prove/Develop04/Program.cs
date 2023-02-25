using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Program");

        var numberChoice = 0;
        while (numberChoice != 4){
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            var choice = Console.ReadLine();
            numberChoice = int.Parse(choice);
            Console.WriteLine("");

            // BREATHING ACTIVITY
            if (numberChoice == 1){

                string activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", activityDescription);
                activity1.DisplayStartingMessage();
                activity1.PausingSpinner("Get ready...");
                Console.WriteLine("");
                activity1.DisplayBreathing();
                activity1.DisplayEndindMessage();
            }

            if (numberChoice == 2){

                string activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                ReflectingActivity activity2 = new ReflectingActivity("Reflecting Activity", activityDescription);
                activity2.DisplayStartingMessage();
                activity2.PausingSpinner("Get ready...");
                Console.WriteLine("");
                
                activity2.DisplayRandomPrompt();
                activity2.DisplayRandomReflectionQuestion();

                activity2.DisplayEndindMessage();
            }

            if (numberChoice == 3){

                string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

                ListingActivity activity3 = new ListingActivity("Reflecting Activity", activityDescription);
                activity3.DisplayStartingMessage();
                activity3.PausingSpinner("Get ready...");
                Console.WriteLine("");

                activity3.DisplayEndindMessage();
            }








        }
    }
}