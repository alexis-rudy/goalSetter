namespace goalSetter;

public class Goal
{
    // Initialize variables for goal
    private string _goalTitle = "";
    private string _goalDescription = "";
    private int _goalPoints = 0;
    private string _goalDifficultly = "";
    private bool _goalComplete = false;
    private static List<string> goalsList = new List<string>();
    
    // Terminal variable
    private Terminal _terminal = new Terminal();
    
    // Constructors
    // For initalizing instance
    public Goal() {}

    // For creating a goal.
    public Goal(string goalTitle, string goalDescription, string goalDifficultly, bool goalComplete)
    {
        _goalTitle = goalTitle;
        _goalDescription = goalDescription;
        _goalDifficultly = goalDifficultly;
        _goalComplete = goalComplete;
    }
    // Getters

    public static List<string> getGoalsList()
    {
        return goalsList;
    }
    public string GetName()
    {
        return _goalTitle;
    }
    public string GetDescription()
    {
        return _goalDescription;
    }
    public int GetPoints()
    {
        return _goalPoints;
    }
    public bool GetComplete()
    {
        return _goalComplete;
    }
    

    // Methods
    public void setPointAmounts(int difficulty)
    {
        switch (difficulty) 
        {
            case 3:
                _goalPoints = 10;
                break;
            case 2:
                _goalPoints = 15;
                break;
            default:
                _goalPoints = 5;
                break;
        }
    }

    // Count all the current goals user has.
    // Returns: an int
    public int getNumGoals()
    {
        return goalsList.Count();
    }

    // Displays all the current goals user has (goals not marked complete).
    // Returns: nothing (writes goals dynamically)
    public void showGoals()
    {
        foreach (var goal in goalsList)
        {
            _terminal.WriteLine(goal);
        }
    }
}