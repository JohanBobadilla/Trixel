using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerData[] players;
    public PlayerData currentPlayer;

    void Start()
    {
        currentPlayer = players[TurnSystem.instance.StartTurns()];
        print(currentPlayer.playerName);
    }
}
