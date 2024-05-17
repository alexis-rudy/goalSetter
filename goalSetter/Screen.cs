using System;
using System.Collections.Generic;

namespace goalSetter;

public class Screen
{
    // Initialize variables
    private Goal goals;
    public static int numGoals;

    private Terminal t = new Terminal();
    private Actions a = new Actions();
    public Screen()
    {   
        this.goals = new Goal();
        numGoals = goals.getNumGoals();
        t.WriteLine("You have " + numGoals + " goals.");
        goals.showGoals();
        
        // Create a new goal
        t.WriteLine("What would you like to do?");
        t.WriteLine("1. Create a new goal");
        t.WriteLine("2. Edit goal");
        int response = t.ReadInt("Write response here: ");

        switch (response)
        {
            case 1:
                a.createNewGoal();
                break;
            case 2:
                break;
            default:
                t.WriteLine("Not valid.");
                break;
        }
    }
}