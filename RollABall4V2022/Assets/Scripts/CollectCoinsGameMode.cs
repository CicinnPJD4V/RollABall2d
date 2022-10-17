using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static GameState;

[CreateAssetMenu(menuName ="Assets/GameModes/CollectCoins", fileName = "CollectCoinsGameModeSO")]
public class CollectCoinsGameMode : GameModesSO
{
    public int coinsToWin;
    
    public float timeToWin;
    /// <summary>
    /// Atualiza o estado do tipo de Collect coins
    /// </summary>
    /// <param name="intValue">Quantidade de moedas coletadas</param>
    /// <param name="floatValue">Tempo que se passou desde do inicio da partida</param>
    public override  void UpdateGameState([Optional]int intValue, [Optional] float floatValue, [Optional] bool boolValue)
    {
        if (intValue >= coinsToWin)
        {
            GameState = GameState.Victory;
            
        }

        if (floatValue >= timeToWin) GameState = GameState.GameOver;
    }
}
