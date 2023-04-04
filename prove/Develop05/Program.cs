using System;
using System.IO;
class Program
{
    static void Main(string[] args)

    {   
        var numberChoice = 0;
        int totalPoints = 0;
        List<Goal> _goals = new List<Goal>();
        while (numberChoice!= 6) {

            Console.WriteLine($"\r\nYou have {totalPoints} points. \r\n");
            Console.WriteLine("Menu Options: \r\n");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit \r\n");
            Console.Write("Select a choice from the menu: ");
            var choice = Console.ReadLine();
            numberChoice = int.Parse(choice);
            Console.WriteLine("");

            // 1 -> Create New Goal
            if (numberChoice == 1) {
                Console.WriteLine("The types of goals are: \r\n");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal \r\n");
                Console.Write("What type of goal would you like to create? ");
                var goalType = Console.ReadLine();
                int goalTypeNumber = int.Parse(goalType);
                Console.WriteLine("");

                // Simple Goal creation
                if (goalTypeNumber == 1) {
                    SimpleGoal simpleGoal = new SimpleGoal("Simple Goal");
                    simpleGoal.SetGoalInfo();
                    _goals.Add(simpleGoal);
                    
                }

                // Eternal Goal creation
                if (goalTypeNumber == 2) {
                    EternalGoal eternalGoal = new EternalGoal("Eternal Goal");
                    eternalGoal.SetGoalInfo();   
                    _goals.Add(eternalGoal);                 
                }

                // Checklist Goal creation
                if (goalTypeNumber == 3) {
                    ChecklistGoal checklistGoal = new ChecklistGoal("Checklist Goal");
                    checklistGoal.SetGoalInfo();
                    _goals.Add(checklistGoal);
                }
            }

            // 2 -> List Goals
            if (numberChoice == 2) {

                int number = 1;
                foreach (var goal in _goals)
                {   
                    if (goal is ChecklistGoal){
                        if (goal._timesCompleted == goal._times){
                            Console.WriteLine($"{number}. [X] {goal._goalName} ({goal._description}) -- Currently completed: {goal._timesCompleted}/{goal._times}");
                        } else {
                            Console.WriteLine($"{number}. [ ] {goal._goalName} ({goal._description}) -- Currently completed: {goal._timesCompleted}/{goal._times}");
                        }

                    }
                    if(goal is SimpleGoal){
                        if (goal._isCompleted is false) {
                            Console.WriteLine($"{number}. [ ] {goal._goalName} ({goal._description})");
                        } else {
                            Console.WriteLine($"{number}. [X] {goal._goalName} ({goal._description})");
                        }

                    }
                    if(goal is EternalGoal) {
                        Console.WriteLine($"{number}. [ ] {goal._goalName} ({goal._description})");
                    }
                    number += 1;
                }
            }

            // 3 -> Save Goals
            if (numberChoice == 3) {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (var goal in _goals)
                    {
                        if (goal is ChecklistGoal){
                            outputFile.WriteLine($"{goal},{goal._goalName},{goal._description},{goal._points},{goal._bonus},{goal._times},{goal._timesCompleted}");
                        }
                        if (goal is SimpleGoal){
                            outputFile.WriteLine($"{goal},{goal._goalName},{goal._description},{goal._points},{goal._isCompleted}");
                        }
                        else {
                            outputFile.WriteLine($"{goal},{goal._goalName},{goal._description},{goal._points}");
                        }
                    }
                }
            }

            // 4 -> Load Goals
            if (numberChoice == 4) {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string goalType = parts[0];

                    if (goalType == "SimpleGoal"){
                        SimpleGoal simpleGoal = new SimpleGoal("Simple Goal");
                        simpleGoal._goalName = parts[1];
                        simpleGoal._description = parts[2];
                        string pointsString = parts[3];
                        simpleGoal._points = int.Parse(pointsString);
                        string isCompleted = parts[4];
                        simpleGoal._isCompleted = bool.Parse(isCompleted);
                        _goals.Add(simpleGoal);
                    }
                    
                    if (goalType == "EternalGoal"){
                        EternalGoal eternalGoal = new EternalGoal("Eternal Goal");
                        eternalGoal._goalName = parts[1];
                        eternalGoal._description = parts[2];
                        string pointsString = parts[3];
                        eternalGoal._points = int.Parse(pointsString);
                        _goals.Add(eternalGoal);
                    }

                    if (goalType == "ChecklistGoal") {
                        ChecklistGoal checklistGoal = new ChecklistGoal("Checklist goal");
                        checklistGoal._goalName = parts[1];
                        checklistGoal._description = parts[2];
                        string pointsString = parts[3];
                        checklistGoal._points = int.Parse(pointsString);
                        string bonus = parts[4];
                        checklistGoal._bonus = int.Parse(bonus); 
                        string times = parts[5];
                        checklistGoal._times= int.Parse(times);  
                        string timesCompleted = parts[6];
                        checklistGoal._timesCompleted = int.Parse(timesCompleted); 
                        _goals.Add(checklistGoal);      
                    }
                }
            }

            // 5 -> Record Event
            if (numberChoice == 5) {

                Console.WriteLine("The goals are:");
                int number = 1;
                foreach (var goal in _goals)
                {                       
                    Console.WriteLine($"{number}. {goal._goalName}");
                    number += 1;
                }

                Console.Write("\r\nWhich goal did you accomplish? ");
                string goalNumberString = Console.ReadLine();
                int goalNumber = int.Parse(goalNumberString);
                goalNumber = goalNumber - 1;

                Goal chosenGoal = _goals[goalNumber];
                int points = chosenGoal._points;

                if (chosenGoal is SimpleGoal){
                    chosenGoal._isCompleted = true;
                }
                if (chosenGoal is ChecklistGoal){
                    chosenGoal._timesCompleted += 1;

                    if (chosenGoal._timesCompleted == chosenGoal._times){
                        points += chosenGoal._bonus;
                    }
                }

                Console.WriteLine($"\r\nCongratulations! You have earned {points} points");
                totalPoints += points;
                Console.WriteLine($"You now have {totalPoints}");
            }
        }
    }
}