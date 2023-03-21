using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTester : MonoBehaviour
{
    GameState currentGameState;

    void Start()
    {
        currentGameState = GameObject.FindGameObjectWithTag("GameState").GetComponent<GameState>();
    }

    // Functions
    void IncreaseScore()
    {
        currentGameState.score += 1;
    }

    void DecreaseScore()
    {
        currentGameState.score -= 1;
    }

    void ResetScore()
    {
        currentGameState.score = 0;
    }

    void SaveScore()
    {
        FindObjectOfType<GameSaveManager>().SaveToDisk();
    }

    void LoadScore()
    {
        FindObjectOfType<GameSaveManager>().LoadFromDisk();
    }
}
