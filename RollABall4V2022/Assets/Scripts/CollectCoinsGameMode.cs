using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Assets/GameModes/Collect")]
public class CollectCoinsGameMode : ScriptableObject , IGameMode<int>
{
    public int coinsToWin;
    public GameState gameState;
    public void UpdateWinState(int value)
    {
        
    }
}
