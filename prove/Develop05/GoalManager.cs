using System.Runtime.CompilerServices;
using System.Xml.Serialization;
public class GoalManager{

    private List<Goal>_goal;
    private int _score;
    // private EternalGoal _eternalGoal;
    // private SimpleGoal _simpleGoal;
    // private ChecklistGoal _checklistGoal;
    public GoalManager(){
        this._goal = new List<Goal>();
        
    }
    public int GetScore(){
        return _score;
    }
    public void SetScore(int score){
        _score = score;
    }

    public void Start(){
        // DisplayPlayerInfo();
        // Console.WriteLine("Menu Options:");
        // Console.WriteLine("1. Create Goal\n "+ "2. List Goals\n "
        // +"3. Save Goals\n " + "4. Load Goals\n "+"5. Record Event\n "+ "6. Quit");
        // Console.Write("Select a choice from the menu: ");
        int UserSelection = 0;
         while (UserSelection != 6){
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create Goal\n "+ "2. List Goals\n "
            +"3. Save Goals\n " + "4. Load Goals\n "+"5. Record Event\n "+ "6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            UserSelection = int.Parse(Console.ReadLine());
            if (UserSelection == 1){
                CreateGoal();
            }
            else if (UserSelection == 2){
                ListGoalDetails();

            }
            else if (UserSelection == 3){
                SaveGoal();

            }
             else if (UserSelection == 4){
                LoadGoals();

            }
             else if (UserSelection == 5){
                RecordEvent();

            }
            else{
            }
        }
    }
    
    public void DisplayPlayerInfo(){
        
        Console.WriteLine($"score = {_score}");

        // foreach(Goal tempGoal in _goal){
        //     if (tempGoal.GetType() == typeof(SimpleGoal)){
        //         SimpleGoal simpleGoal = (SimpleGoal)tempGoal;
        //         if (simpleGoal.IsCompleted()){
        //             totalPoints += simpleGoal.GetPoints();
        //         }
        //     }
        //     else if(tempGoal.GetType() == typeof(EternalGoal)){
        //         EternalGoal eternalGoal = (EternalGoal)tempGoal;  
        //     }
        //     else if(tempGoal.GetType() == typeof(ChecklistGoal)){
        //         ChecklistGoal checklistGoal = (ChecklistGoal)tempGoal;
        //     }
        // }
    }
    public void ListGoalNames(){
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal\n "+"2. Eternal Goal\n "+"3. Checklist Goal ");
    }
    public void CreateGoal(){
        ListGoalNames(); 
        Console.WriteLine("Which type of goal would like to create? ");
        int UserSelection = int.Parse(Console.ReadLine());
        while(UserSelection != 4){
            if (UserSelection == 1){
                SimpleGoal sgoal = new SimpleGoal();
                Console.WriteLine("What is the name of your goal? ");
                sgoal.SetShortName(Console.ReadLine());
                Console.WriteLine("What is a short discription of it? ");
                sgoal.SetDescription(Console.ReadLine());
                Console.WriteLine("How many points do you want it to be? ");
                sgoal.SetPoints(int.Parse(Console.ReadLine()));
                // Console.WriteLine("is it completed? ");
                // sgoal.SetIsCompleted(bool.Parse(Console.ReadLine()));
                this._goal.Add(sgoal);
                return;
            }

            else if (UserSelection == 2){
                EternalGoal egoal = new EternalGoal();
                Console.WriteLine("What is the name of your goal? ");
                egoal.SetShortName(Console.ReadLine());
                Console.WriteLine("What is a short discription of it? ");
                egoal.SetDescription(Console.ReadLine());
                Console.WriteLine("How many points do you want it to be? ");
                egoal.SetPoints(int.Parse(Console.ReadLine()));
                this._goal.Add(egoal);
                return;
            }
            
            else if (UserSelection == 3){
                ChecklistGoal cgoal = new ChecklistGoal();
                Console.WriteLine("What is the name of your goal? ");
                cgoal.SetShortName(Console.ReadLine());
                Console.WriteLine("What is a short discription of it? ");
                cgoal.SetDescription(Console.ReadLine());
                Console.WriteLine("How many points do you want it to be? ");
                cgoal.SetPoints(int.Parse(Console.ReadLine()));
                Console.WriteLine("how many times does this need to be completed for a bonus? ");
                cgoal.SetTarget(int.Parse(Console.ReadLine()));
                Console.WriteLine("How many points is the bonus worth? ");
                cgoal.SetBonus(int.Parse(Console.ReadLine()));
                this._goal.Add(cgoal);
                return;
            }
            else {
                Console.WriteLine("Not a valid choice");
                return;
            }
        }    
    }

    public void RecordEvent(){
        //display saved goals in list, then use elementAt to pick goal at index to record a change.
        Console.WriteLine("The goals are: ");
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        Console.WriteLine("");
        var goalNum = Convert.ToInt32(Console.ReadLine()) - 1;
        var addPoints = _goal[goalNum].RecordEvent();
        _score += addPoints;
        Console.WriteLine($"Congratulations! You just earned {addPoints} points.");
        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoal(){
        Console.Write($"What would you like to name the file? ");
        string file = Console.ReadLine();
                
        using (StreamWriter outputFile = new StreamWriter(file))
            {

            //for each list Entry write line to the output file
                foreach (Goal g in _goal){
                    outputFile.WriteLine(g.GetStringRepresentation());
                }
            }
    }
    public void ListGoalDetails(){
        int i = 1;
        foreach (Goal goal in _goal){
            if (goal.IsCompleted())
            {
                Console.WriteLine($"{i}. [x] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{i}. [ ] {goal.GetDetailsString()}");
            }
            i++;
        }
    }
    public void LoadGoals(){
        Console.WriteLine("name of file your goals is located?");
        string pathtofile = Console.ReadLine();
        string[] linesOfTextInFile = File.ReadAllLines(pathtofile);
        foreach (string lineOfText in linesOfTextInFile){
            // see which type of goal it is
            if (lineOfText.Contains("SimpleGoal")){
                SimpleGoal sgoal = new SimpleGoal();
                // substring the the lineOfText removing the type of goal and only leave the relavent fields
                // your line of text essentially looks like this 
                // lineOfText == SimpleGoal:Don't be a cuck,Pleasure your girl,100,True
                // remove the first part using math to figure out how many characters is in "SimpleGoal:" // 11 characters need to be out
                string preppedString = lineOfText.Remove(0, 11);
                // lineOfText or tempstring = "Don't be a cuck,Pleasure your girl,100,True"
                // then parse out each value for your getters to use
                string[] tempHolder = preppedString.Split(",");
                sgoal.SetShortName(tempHolder[0]);
                sgoal.SetDescription(tempHolder[1]);
                sgoal.SetPoints(int.Parse(tempHolder[2]));
                sgoal.SetIsCompleted(bool.Parse(tempHolder[3]));
                _goal.Add(sgoal);

            } else if (lineOfText.Contains("EternalGoal")) {
                EternalGoal egoal = new EternalGoal();
                string preppedString = lineOfText.Remove(0,11);
                string[] tempHolder = preppedString.Split(",");
                egoal.SetShortName(tempHolder[0]);
                egoal.SetPoints(int.Parse(tempHolder[2]));
                _goal.Add(egoal);
            } else {

            }

        }
    }
}