using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int playerScore;
    public int playerLevel;
    public Sprite playerSprite;

    public PlayerData(string name, int score, int level, Sprite sprite)
    {
        playerName = name;
        playerScore = score;
        playerLevel = level;
        playerSprite = sprite;
    }
}
