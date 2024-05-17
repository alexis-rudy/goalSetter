namespace goalSetter;

public class OneTimeGoal:Goal
{
    public OneTimeGoal()
    {
    }

    private OneTimeGoal(string name, string description, string difficulty) :
        base(name, description, difficulty, false)
    {
    }

}