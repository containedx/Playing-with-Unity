using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameInfo
{
    [SerializeField]
    private string gameName;
    public string GameName => gameName;

    [SerializeField]
    private float gameDuration;
    public float GameDuration => gameDuration;

    [SerializeField]
    private Color playerColor;
    public Color PlayerColor => playerColor; 

}
