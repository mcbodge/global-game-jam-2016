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

    public List<Level> Player1LevelsQueue;
    public List<Level> Player2LevelsQueue;

    public float Player1Points;
    public float Player2Points;

    public int Player1CurrentLevelIndex;
    public int Player2CurrentLevelIndex;

    public TotemColumn Totem1;
    public TotemColumn Totem2;
    public bool IsLerping = false;

    // Use this for initialization
    void Start()
    {
        Player1Points = Player2Points = 0f;
        Player1CurrentLevelIndex = Player2CurrentLevelIndex = -1;

        // Add 3 different levels to the queue;
        // Assign first level to both players
        AssignNextLevel(Player.Player1);
        AssignNextLevel(Player.Player2);
    }

    void Awake()
    {
        Instance = this;
    }

    public void AssignNextLevel(Player player, float points = 0.0f)
    {
        switch (player)
        {
            case Player.Player1:
                if (Player1CurrentLevelIndex > -1)
                {
                    Player1LevelsQueue[Player1CurrentLevelIndex].IsActive = false;
                    Player1LevelsQueue[Player1CurrentLevelIndex].enabled = false;
                    Totem1.StartLerping();
                }
                Player1Points += points;
                Player1CurrentLevelIndex++;
                Player1LevelsQueue[Player1CurrentLevelIndex].CurrentPlayer = player;
                Player1LevelsQueue[Player1CurrentLevelIndex].IsActive = true;
                break;
            case Player.Player2:
                if (Player2CurrentLevelIndex > -1)
                {
                    Player2LevelsQueue[Player2CurrentLevelIndex].IsActive = false;
                    Totem2.StartLerping();
                    Player2LevelsQueue[Player2CurrentLevelIndex].enabled = false;
                }
                Player2Points += points;
                Player2CurrentLevelIndex++;
                Player2LevelsQueue[Player2CurrentLevelIndex].CurrentPlayer = player;
                Player2LevelsQueue[Player2CurrentLevelIndex].IsActive = true;
                break;
        }
    }
}
