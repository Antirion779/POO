using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OffensifItemData : Equipement, IPointerEnterHandler
{
    public enum WeaponTypeEnum
    {
        Sword,
        Scepter,
        Bow,
    }

    public WeaponTypeEnum weaponType;

    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        InventoryManager.instance.categorieText.text = "Offensif Item";
    }
}
