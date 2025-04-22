using UnityEngine;

public class CellController : MonoBehaviour
{
    public SpriteRenderer symbol;
    
    private bool occupiedCell = false;


    void Start()
    {

    }

    private void OnMouseDown()
    {
        if (occupiedCell) return;
        print(occupiedCell);
        // simboloRenderer.sprite = playerSprite;
        occupiedCell = true;

    }
}
