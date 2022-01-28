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
        base.OnPointerEnter(eventData);
        InventoryManager.instance.classText.text = "Class : " + (role.ToString());
        InventoryManager.instance.reputevilText.text = "Reupuattion : " + (reputation.ToString());
        InventoryManager.instance.categorieText.text = "Categorie : Good Boy";
    }
}
