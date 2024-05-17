namespace goalSetter;

public class LongGoal:Goal
{
    public LongGoal()
    {
    }

    public LongGoal(string name, string description, string difficulty) :
        base(name, description, difficulty, false)
    {
    } 
}