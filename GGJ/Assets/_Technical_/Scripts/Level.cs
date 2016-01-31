using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour
{

    public Player CurrentPlayer;
    public PlayerController CurrentPlayerController;
    public bool IsActive = false;

    // Update is called once per frame
    void Update()
    {
        if (IsActive)
        {
            CheckGoal();
        }
    }

    public void GoalHasBeenReached(float points = 0.16f)
    {
        SceneControl.Instance.AssignNextLevel(CurrentPlayer, points);
    }

    public virtual void CheckGoal() { }

}
