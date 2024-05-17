namespace goalSetter;

public class DailyGoal : Goal
{
    public DailyGoal()
    {
    }

    public DailyGoal(string name, string description, string difficulty) :
        base(name, description, difficulty, false)
    {
    }
}
        