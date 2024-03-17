using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerup/HealthBuff")]
public class HealingBuff : PowerupEffect
{
    public int amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<UnitHealth>().Heal(amount);
    }
}
