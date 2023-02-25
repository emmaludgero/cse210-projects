public class BreathingActivity : Activity{

    public BreathingActivity(string activityName, string description) : base (activityName, description){

    }

    public void DisplayBreathing(){

        int speed = 0;
        do {    

            if (speed != _duration){
                Console.Write("Breath in...");
                PausingCountdown();
                Console.WriteLine("");
                Console.Write("Now breath out...");
                PausingCountdown();
                Console.WriteLine("");
                Console.WriteLine("");
                speed += 1000;
            } else{
                break;
            }

        } while (true);
        
    }


}