using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour
{
    public string name;

    public int life;
    public int armor;
    public int damage;

    public int money;

    public bool isMagical;
    public virtual void Info()
    {
       Debug.Log(name + " says Hello !");
    }
}

public class BadBoy : Characters
{
    enum BadBoys
    {
        DarkMage,
        Oger,
        Goblin,
    }

    private int evilness;
}
