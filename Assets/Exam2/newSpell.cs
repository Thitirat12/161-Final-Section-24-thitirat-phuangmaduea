using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpell : Spell
{
    public override void init(string enemy, int power, string spellName)
    {
        enemyName = "God";
        power = 100;
        spellName = "LightSpell";
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
