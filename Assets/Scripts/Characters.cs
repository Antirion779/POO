using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Characters : MonoBehaviour
{

    [SerializeField] private int _life;
    public int life
    {
        get { return _life; }
        set { _life = value; }
    }

    [SerializeField] private int _armor;
    public int armor
    {
        get { return _armor; }
        set { _armor = value; }
    }

    [SerializeField] private int _damage;
    public int damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    [SerializeField] private int _money;
    public int money
    {
        get { return _money; }
        set { _money = value; }
    }

    [SerializeField] private bool _isMagical;
    public bool isMagical
    {
        get { return _isMagical; }
        set { _isMagical = value; }
    }

    [SerializeField] private int _range;
    public int range
    {
        get { return _range; }
        set { _range = value; }
    }
    public virtual void Info()
    {
       Debug.Log(name + " says Hello !");
    }
}
