using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public InventoryObject inventory;
    public InventoryObject equipment;
    public PlayerSkills playerSkills; // Reference to PlayerSkills

    public Attribute[] attributes;

    private void Start()
    {
        for (int i = 0; i < attributes.Length; i++)
        {
            attributes[i].SetParent(this);
        }
        for (int i = 0; i < equipment.GetSlots.Length; i++)
        {
            equipment.GetSlots[i].OnBeforeUpdate += OnBeforeSlotUpdate;
            equipment.GetSlots[i].OnAfterUpdate += OnAfterSlotUpdate;
        }

        if (playerSkills == null)
        {
            Debug.LogError("PlayerSkills reference is not set in the Inspector");
        }
    }

    public void OnBeforeSlotUpdate(InventorySlot _slot)
    {
        if (_slot.ItemObject == null)
            return;
        switch (_slot.parent.inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                print(string.Concat("Removed ", _slot.ItemObject, " on ", _slot.parent.inventory.type, ", Allowed Items: ", string.Join(", ", _slot.AllowedItems)));

                for (int i = 0; i < _slot.item.buffs.Length; i++)
                {
                    for (int j = 0; j < attributes.Length; j++)
                    {
                        if (attributes[j].type == _slot.item.buffs[i].attributesItem)
                        {
                            attributes[j].value.RemoveModifier(_slot.item.buffs[i]);
                            UpdatePlayerSkill(attributes[j].type, -_slot.item.buffs[i].value);
                        }
                    }
                }

                break;
            case InterfaceType.Chest:
                break;
            default:
                break;
        }
    }

    public void OnAfterSlotUpdate(InventorySlot _slot)
    {
        if (_slot.ItemObject == null)
            return;
        switch (_slot.parent.inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                print(string.Concat("Placed ", _slot.ItemObject, " on ", _slot.parent.inventory.type, ", Allowed Items: ", string.Join(", ", _slot.AllowedItems)));

                for (int i = 0; i < _slot.item.buffs.Length; i++)
                {
                    for (int j = 0; j < attributes.Length; j++)
                    {
                        if (attributes[j].type == _slot.item.buffs[i].attributesItem)
                        {
                            attributes[j].value.AddModifier(_slot.item.buffs[i]);
                            UpdatePlayerSkill(attributes[j].type, _slot.item.buffs[i].value);
                        }
                    }
                }

                break;
            case InterfaceType.Chest:
                break;
            default:
                break;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        var groundItem = other.GetComponent<GroundItem>();
        if (groundItem)
        {
            Item _item = new Item(groundItem.item);
            if (inventory.AddItem(_item, 1))
            {
                Destroy(other.gameObject);
            }
        }
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    inventory.Save();
        //    equipment.Save();
        //}
        //if (Input.GetKeyDown(KeyCode.KeypadEnter))
        //{
        //    inventory.Load();
        //    equipment.Load();
        //}
    }

    public void AttributeModified(Attribute attribute)
    {
        Debug.Log(string.Concat(attribute.type, " was updated! Value is now ", attribute.value.ModifiedValue));
        UpdatePlayerSkill(attribute.type, attribute.value.ModifiedValue); // Update player skills when attribute is modified
    }

    private void UpdatePlayerSkill(AttributesItem type, int value)
    {
        if (playerSkills == null)
        {
            Debug.LogError("PlayerSkills reference is not set.");
            return;
        }

        Debug.Log("Updating player skill: " + type + " by " + value);
        
        switch (type)
        {
            case AttributesItem.GreatWeapons:
                playerSkills.greatWeapons += value;
                break;
            case AttributesItem.RangedWeapons:
                playerSkills.rangedWeapons += value;
                break;
            case AttributesItem.SmallWeapons:
                playerSkills.smallWeapons += value;
                break;
            case AttributesItem.Conjuration:
                playerSkills.conjuration += value;
                break;
            case AttributesItem.Lockpicking:
                playerSkills.lockpicking += value;
                break;
            case AttributesItem.Camouflage:
                playerSkills.camouflage += value;
                break;
            case AttributesItem.Defense:
                playerSkills.defense += value;
                break;
            case AttributesItem.Medicine:
                playerSkills.medicine += value;
                break;
            case AttributesItem.Trade:
                playerSkills.trade += value;
                break;
            case AttributesItem.Oratory:
                playerSkills.oratory += value;
                break;
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Clear();
        equipment.Clear();
    }
}

[System.Serializable]
public class Attribute
{
    [System.NonSerialized]
    public Collect parent;
    public AttributesItem type;
    public ModifiableInt value;

    public void SetParent(Collect _parent)
    {
        parent = _parent;
        value = new ModifiableInt(AttributeModified);
    }

    public void AttributeModified()
    {
        parent.AttributeModified(this);
    }
}
