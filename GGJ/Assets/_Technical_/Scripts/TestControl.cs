using UnityEngine;
using System.Collections;

public class TestControl : Level {

    public bool HasWon = false;

    public override void CheckGoal()
    {
        //TODO Specific level business logic
        if (HasWon)
        {
            HasWon = false;
            GoalHasBeenReached();
        }
    }

}
