using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class GameModesSO : ScriptableObject
{
    public Action<GameState> OnGameStateChanged;

    protected GameState GameState
    {
        get => gameState;

        set
        {
            if (value == gameState) return;
            gameState = value;
            OnGameStateChanged?.Invoke(gameState);
        }
    }
   protected GameState gameState;

   public virtual void InitializeMode()
   {
       gameState = GameState.Start;
   }
   public virtual void UpdateGameState([Optional]int intValue, [Optional] float floatValue, [Optional] bool boolValue)
   {
      
   }

   public virtual GameState CheckGameState()
   {
      return gameState;
    }
}
