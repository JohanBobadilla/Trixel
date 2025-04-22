using UnityEngine;
using System;

[Serializable]
public class PlayerData
{
    public string playerName;
    public int playerScore;
    public Sprite playerSprite;
    public PlayerType playerType;

    public PlayerData(string name, int score, PlayerType player, Sprite sprite)
    {
        playerName = name;
        playerScore = score;
        playerSprite = sprite;
        playerType = player;
    }
}


