using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum PlatformType
{
    Neutro,
    Triggerable
}

public class SequenceLevel : Level
{

    public int GoalIndexInTheSequence;
    public int CurrentIndex = 0;
    public bool WentOnNeutro;

    public override void CheckGoal()
    {
        if (GoalIndexInTheSequence.Equals(CurrentIndex)){
            GoalHasBeenReached();
        }
    }

    public void UpdateFSA(PlatformType type, int index = -1)
    {
        if (type.Equals(PlatformType.Triggerable) && (CurrentIndex == index - 1 || !WentOnNeutro && CurrentIndex.Equals(index)))
        {
            CurrentIndex = index;
            WentOnNeutro = false;
        }
        else if (type.Equals(PlatformType.Triggerable))
        {
            CurrentIndex = 0;
            WentOnNeutro = false;
        }
        else if (type.Equals(PlatformType.Neutro))
        {
            WentOnNeutro = true;
        }
    }
}
