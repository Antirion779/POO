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
        base.OnPointerEnter(eventData);
        InventoryManager.instance.classText.text = "Class : " + (role.ToString());
        InventoryManager.instance.reputevilText.text = "Evilness : " + (evilness.ToString());
        InventoryManager.instance.categorieText.text = "Categorie : Bad Boy";
    }
}
