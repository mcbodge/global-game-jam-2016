using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum Player : int
{
    Player1 = 0,
    Player2 = 1
}

public class SceneControl : MonoBehaviour
{

    public static SceneControl Instance;

    public List<Level> levelsQueue;

    public List<float> Points;

    public List<int> LevelIndexes;

    private List<Level> currentLevels;

    private bool isFirstLoad = true;



    // Use this for initialization
    void Start()
    {
        ////levelsQueue = new List<Level>();
        Points = new List<float>(2);
        Points.Add(0f);
        Points.Add(0f);
        ////LevelIndexes = new List<int>(2);
        currentLevels = new List<Level>(2);
        currentLevels.Add(new Level());
        currentLevels.Add(new Level());
        // Add 3 different levels to the queue;
        // Assign first level to both players
        ////AssignLevelToPlayer(Player.Player1, levelsQueue[0]);
        ////AssignLevelToPlayer(Player.Player2, levelsQueue[0]);
        isFirstLoad = false;
    }

    void Awake()
    {
        Instance = this;
    }

    private void AssignLevelToPlayer(Player player, Level level)
    {
        int playerIndex = (int)player;

        if (!isFirstLoad)
        {
            currentLevels[playerIndex].IsActive = false;
            //TODO move levels wrt camera
            currentLevels[playerIndex].enabled = false;
        }
        currentLevels[playerIndex] = level;
        currentLevels[playerIndex].CurrentPlayer = player;
        currentLevels[playerIndex].IsActive = true;
    }

    public void AssignNextLevel(Player player)
    {
        int playerIndex = (int)player;

        currentLevels[playerIndex].IsActive = false;
        //TODO move levels wrt camera
        currentLevels[playerIndex].enabled = false;

        LevelIndexes[playerIndex] += 1;
        // next level
        currentLevels[playerIndex] = levelsQueue[LevelIndexes[playerIndex]];
        currentLevels[playerIndex].CurrentPlayer = player;
        currentLevels[playerIndex].IsActive = true;
    }
}
