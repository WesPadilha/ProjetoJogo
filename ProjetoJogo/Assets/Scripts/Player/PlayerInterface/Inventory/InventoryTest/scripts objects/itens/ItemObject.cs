using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Helmet,
    Chest,
    Pants,
    Boots,
    Accessories,
    Weapon,
    Shield,
    Default
}

public enum AttributesItem
{
    Agility,
    Intellect,
    Stamina,
    Strngth
}
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory System/Items/item")]
public class ItemObject : ScriptableObject
{
    public Sprite uiDisplay;
    public bool stackable;   
    public ItemType type;
    [TextArea(15,20)]
    public string description;
    public Item data = new Item();    

    public Item CreateItem()
    {
        Item newItem = new Item(this);
        return newItem;
    }
}

[System.Serializable]
public class Item
{
    public string Name;
    public int Id = -1;
    public ItemBuff[] buffs; // Ensure this is defined in the Item class
    public Item()
    {
        Name = "";
        Id = -1;
    }
    public Item(ItemObject item)
    {
        Name = item.name;
        Id = item.data.Id;
        buffs = new ItemBuff[item.data.buffs.Length]; // Correctly initialize the buffs array using the item instance
        for (int i = 0; i < buffs.Length; i++)
        {
            buffs[i] = new ItemBuff(item.data.buffs[i].min, item.data.buffs[i].max)
            {
                attributesItem = item.data.buffs[i].attributesItem
            };
        }
    }
}

[System.Serializable]
public class ItemBuff
{
    public AttributesItem attributesItem;
    public int value;
    public int min;
    public int max;
    public ItemBuff(int _min, int _max)
    {
        min = _min;
        max= _max;
        GenerateValue();
    }
    public void GenerateValue()
    {
        value = UnityEngine.Random.Range(min, max);
    }
}