using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player_Data", menuName = "Scriptable Object/Player Data")]
public class PlayerData : ScriptableObject
{
    [Header("Player")]
    public int playerLevel;
    public int coins;

    [Header("Items")]
    public int collectedItems;
    public int collectedDeathItems;

    [Header("Lives")]
    public int lives;

    [Header("Game state")]
    public bool isLose;
    public bool isMascotEnd;

    [Header("Player Drones")]
    public bool hasDrone1;
    public bool hasDrone2;
    public bool hasDrone3;
    public bool hasDrone4;
    public bool hasDrone5;

}
