using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DefensifItemData : Equipement, IPointerEnterHandler
{
    public enum WeaponTypeEnum
    {
        Shield,
        MageDress,
        LeatherArmor,
    }

    public WeaponTypeEnum weaponType;

    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        InventoryManager.instance.categorieText.text = "Deffensif Item";
    }
}
