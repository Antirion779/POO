using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoodboyData : Characters, IPointerEnterHandler
{
    public enum Class
    {
        Mage,
        Guerrier,
        Archer,
    };

    public Class role;

    [SerializeField] private int _reputation;
    public int reputation
    {
        get { return _reputation; }
        set { _reputation = value; }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        InventoryManager.instance.NameText.text = "Name : " + role.ToString() + name.ToString();
        InventoryManager.instance.lifeText.text = "Life : " + (life.ToString());
        InventoryManager.instance.armorText.text = "Armor : " + (armor.ToString());
        InventoryManager.instance.dammageText.text = "Dammage : " + (damage.ToString());
        InventoryManager.instance.moneyText.text = "Money : " + (money.ToString());
        InventoryManager.instance.rangeText.text = "Range : " + (range.ToString());
        InventoryManager.instance.classText.text = "Class : " + (role.ToString());
        InventoryManager.instance.reputevilText.text = "Réputation : " + (reputation.ToString());
        InventoryManager.instance.categorieText.text = "Categorie : Good Boy";
    }

    /*public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("reset");
    }*/
}
