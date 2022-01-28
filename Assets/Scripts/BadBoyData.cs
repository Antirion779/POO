using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BadBoyData : Characters, IPointerEnterHandler
{
    public enum Class
    {
        DarkMage,
        Oger,
        Skeleton,
    }

    public Class role;

    [SerializeField] private int _evilness;
    public int evilness
    {
        get { return _evilness; }
        set { _evilness = value; }
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
        InventoryManager.instance.reputevilText.text = "Evilness : " + (evilness.ToString());
        InventoryManager.instance.categorieText.text = "Categorie : Bad Boy";
    }
}
