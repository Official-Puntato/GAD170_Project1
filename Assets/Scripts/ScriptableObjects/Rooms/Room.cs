using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Room Type", menuName = "Room")]
public class Room : ScriptableObject
{
    public string roomName;
    public char roomDifficulty;
    public bool hasEnemies;
    public bool hasVendor;
    public char vendorType;
    public bool isIntroRoom;
}
