using UnityEngine;
using System.Collections;

public enum CollectableType
{
    Good,
    Bad
}

public class CollectLevel : Level
{
    public int NumberOfGoodObjects;
    public int CollectedObjects = 0;

    public override void CheckGoal()
    {
        if (CollectedObjects.Equals(NumberOfGoodObjects))
            GoalHasBeenReached();
    }
}
