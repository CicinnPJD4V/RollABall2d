using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu(menuName ="Assets/GameModes/ReachDestination", fileName = "ReachDestinationGameModeSO")]
public class ReachDestinationGameMode : GameModesSO
{
    public bool userTimer;
    public float timeToLose;
    public override  void UpdateGameState([Optional]int intValue, [Optional] float floatValue, [Optional] bool boolValue)
    {
        if (boolValue)
        {
            GameState = GameState.Victory;
        }

        if (boolValue && timeToLose <= floatValue)
        {
            GameState = GameState.GameOver;
        }
    }
}
