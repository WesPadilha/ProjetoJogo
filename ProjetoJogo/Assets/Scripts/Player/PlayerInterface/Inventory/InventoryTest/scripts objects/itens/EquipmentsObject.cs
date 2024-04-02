using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Item/Equipment")]
public class EquipmentsObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}