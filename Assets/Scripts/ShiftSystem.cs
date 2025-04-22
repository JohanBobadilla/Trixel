using UnityEngine;
public class ShiftSystem : MonoBehaviour
{
    public GameTurn currentTurn;


    public void ShiftStart()
    {
        currentTurn = Random.Range(0, 2) == 0 ? GameTurn.Player : GameTurn.Pc;
    }
    public void ChangeTurn()
    {
        if (currentTurn == GameTurn.Player)
        {
            currentTurn = GameTurn.Pc;
        }
        else
        {
            currentTurn = GameTurn.Player;
        }
    }
}
