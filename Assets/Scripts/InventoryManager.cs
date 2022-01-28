using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager _instance;
    public static InventoryManager instance { get { return _instance; } }

    public List<Characters> charactersList;

    [Header("Text")] 
    [SerializeField] public Text NameText;
    [SerializeField] public Text lifeText;
    [SerializeField] public Text armorText;
    [SerializeField] public Text dammageText;
    [SerializeField] public Text moneyText;
    [SerializeField] public Text rangeText;
    [SerializeField] public Text classText;
    [SerializeField] public Text reputevilText;
    [SerializeField] public Text categorieText;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("plus d'une instance de GameManger dans la scène !"); 
            return;
        }
        _instance = this;
    }
}
