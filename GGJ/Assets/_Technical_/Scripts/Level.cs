using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

    public Player CurrentPlayer;
    public PlayerController CurrentPlayerController;
    public bool IsActive = false;
	
	// Update is called once per frame
	void Update () {
        if (IsActive)
        {
            CheckGoal();
        }
	}

    public void GoalHasBeenReached(int points = 10)
    {
        int currentPlayerInt = (int)CurrentPlayer;
        SceneControl.Instance.Points[currentPlayerInt] += points;
        SceneControl.Instance.LevelIndexes[currentPlayerInt] += 1;
        SceneControl.Instance.AssignNextLevel(CurrentPlayer);
    }

    public virtual void CheckGoal() { }
    
}
