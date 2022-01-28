using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    [SerializeField] public TypeEnum type;
    public enum TypeEnum
    {
        offensif_Bonus,
        defensif_Malus,
    }


    [SerializeField] private int _mainStat;
    public int mainStat
    {
        get { return _mainStat; }
        set { _mainStat = value; }
    }

    [SerializeField] private int _mainStatBonus;
    public int mainStatBonus
    {
        get { return _mainStatBonus; }
        set { _mainStatBonus = value; }
    }

    [SerializeField] public Rarity rarity;
    public enum Rarity
    {
        Commun,
        Uncommun,
        Rare,
        Epic,
        Legendary,
    }


}
