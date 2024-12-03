using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public string enemyName;
    public int power;
    public string spellName;

    public virtual void init(string enemy, int power,string spellname)
    {

    }
    public virtual void Cast()
    {
        Debug.Log("casting spell");
    }

    private void Start()
    {
        Debug.Log("Spell-Casting Simulation started!");
        Debug.Log("Casting Generic spell");
    }
}
