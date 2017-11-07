using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Playing = 0,
    Caught
};

public class GameManager : MonoBehaviour
{

    public GameState _GameState;

    void Start()
    {
        _GameState = GameState.Playing;

        Time.timeScale = 1f;
    }

    void Update()
    {
        if(_GameState == GameState.Caught)
        {
            Time.timeScale = 0f;
        }
    }
}
