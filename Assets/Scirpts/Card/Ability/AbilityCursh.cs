using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Cursh", menuName = "SO/AbilityBase/Cursh")]
public class AbilityCursh : AbilityBase
{
    ///jΣEGζLεδυIpY’¬QCjΣYεδυB
    
    private void Ability_Cursh(SO_Unit CauseUnit, SO_Unit HurtUnit, int Dmg)//’¬QdΚ ,σQdΚ
    {
        if (HurtUnit.UnitTpye == UnitTpye.Barrier)
            HurtUnit.TakeDamger(9999, CauseUnit, UnitHitTpye.Hit,AttackDamgerTpye.Enforce);
        if (HurtUnit.Equipment != null)
            HurtUnit.RemoveEquipment();

    }

    public override void AddUseAbility(SO_Unit unit)
    {
        unit.Event_CauseDamage += Ability_Cursh;
    }
    public override void RemoveAbility(SO_Unit unit)
    {
        unit.Event_CauseDamage -= Ability_Cursh;
    }
    public override void Stack(bool IsAdd)
    {
        return;
    }
}
