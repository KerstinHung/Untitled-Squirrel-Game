using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class ItemData : ScriptableObject
{
    public int width = 1;
    public int height = 1;

    public Sprite itemIcon;

    public string itemName;
    public int itemID;
    public string itemDesc;
    public int itemPower;
    public int capacity;
    public ItemType itemType;
    public enum ItemType {
        Tool,
        Consumable,
        Quest
    }
}
