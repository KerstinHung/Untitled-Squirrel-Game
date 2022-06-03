using System.Collections;
using UnityEngine;

[System.Serializable]
public class Item {
    public string itemName;
    public int itemID;
    public string itemDesc;
    public Texture2D itemIcon;
    public int itemPower;
    public ItemType itemType;

    public enum ItemType {
        Tool,
        Consumable,
        Quest
    }

    public Item(string name, int id, string desc, int power, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
        itemPower = power;
        itemType = type;
    }

    public Item()
    {
        
    }
}
