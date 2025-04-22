using UnityEngine;
public class TurnSystem : MonoBehaviour
{
    public static TurnSystem instance;
    private int currentPlayerTurn;

    void Awake()
    {
        if (instance != null) {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
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
