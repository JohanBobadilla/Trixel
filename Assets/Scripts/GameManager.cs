using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerData[] players;
    public PlayerData currentPlayer;
    private int currentPlayerTurn;

    void Start()
    {
        currentPlayer = players[StartTurns()];
        print(currentPlayer.playerName);
    }
    public int StartTurns()
    {
        currentPlayerTurn = Random.Range(0, 2);
        return currentPlayerTurn;
    }

    public int ChangeTurn()
    {
        return currentPlayerTurn == 1 ? 0 : 1;
    }
}
