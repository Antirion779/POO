using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Equipement : Items, IPointerEnterHandler
{
    [SerializeField] private float _enchantBonus;
    public float enchantBonus
    {
        get { return _enchantBonus; }
        set { _enchantBonus = value; }
    }

    [SerializeField] private float _level;
    public float level
    {
        get { return _level; }
        set { _level = value; }
    }

    public float GetRarityBonus(Rarity rarity)
    {
        float bonus = 1;

        switch (rarity)
        {
            case Rarity.Uncommun:
                bonus = 1.0f;
                break;
            case Rarity.Commun:
                bonus = 1.2f;
                break;
            case Rarity.Rare:
                bonus = 2.0f;
                break;
            case Rarity.Epic:
                bonus = 5.0f;
                break;
            case Rarity.Legendary:
                bonus = 10.0f;
                break;
        }

        return bonus;
    }

    public virtual void OnPointerEnter(PointerEventData eventData)
    {
        InventoryManager.instance.NameText.text = " Name : " + name;
        InventoryManager.instance.lifeText.text = "Main Stat : " + mainStat;
        InventoryManager.instance.armorText.text = "Enchantement Bonus : " + enchantBonus;
        InventoryManager.instance.dammageText.text = "Level : " + level;
        InventoryManager.instance.moneyText.text = "Stat With Bonus : " + mainStatBonus;
        InventoryManager.instance.rangeText.text = " ";
        InventoryManager.instance.classText.text = " ";
        InventoryManager.instance.reputevilText.text = " ";
        
    }
}
