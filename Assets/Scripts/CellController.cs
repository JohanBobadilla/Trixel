using UnityEngine;

public class CellController : MonoBehaviour
{
    public int cellIndex;
    public Sprite playerSprite;
    public Sprite pcSprite;
    public SpriteRenderer simboloRenderer;
    private bool ocupado = false;



    private void OnMouseDown()
    {
        if (ocupado) return;
        print(ocupado);
        simboloRenderer.sprite = playerSprite;
        ocupado = true;
    }
}
