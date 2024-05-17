namespace goalSetter;

public class Actions
{
    private Terminal _terminal = new Terminal();
    
    public void createNewGoal()
    {
        try
        {
            string name = _terminal.ReadString("Goal name: ");
            string description = _terminal.ReadString("Describe your goal: ");
            string difficulty = _terminal.ReadString("Difficulty level: ");
            int type = _terminal.ReadInt("Type: ");

            Goal g = new Goal(name, description, difficulty, false);
        }
        catch (Exception e)
        {
            _terminal.WriteLine("Oops there was an error.");
            throw;
        }
    }
}