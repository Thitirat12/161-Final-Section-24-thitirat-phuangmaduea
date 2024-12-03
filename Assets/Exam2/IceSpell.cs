using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public override void init(string enemy, int power, string spellName)
    {
        enemyName = "Zombie";
        power = 3;
        spellName = "IceSpell";
    }

    public override void Cast()
    {
        Debug.Log($"Casting {spellName} to {enemyName} by spell level {power}");
    }

    private void Start()
    {
        init(enemyName, power, spellName);
        Cast();
    }
}
