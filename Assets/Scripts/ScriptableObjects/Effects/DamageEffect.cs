using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Damage Effect", menuName = "Effects/Damage Effect")]
public class DamageEffects : ScriptableObject
{
    public string effectName;
    public string effectType;
    public int effectIndex;
    public int damageMin;
    public int damageMax;
    public DamageType damageType;
    public bool damageOverTime;
    public int damageOverTimeTurns;

    public void ApplyEffect(GameObject target)
    {
        int damageFinal = (Random.Range(damageMin, damageMax));
        /*float health = target.GetComponent<Health>();
        bool targetDOT = target.GetComponent<IsTakingDOT>();
        int targetDOTTimer = target.GetComponent<DOTTimer>();
        float targetDOTdmg = target.GetComponent<DOTDamage>();
        if (health != null)
        {
            health -= damageFinal;
            if (damageOverTime)
            {
                targetDOT = true;
                targetDOTTimer = damageOverTimeTurns;
                targetDOTdmg = (damageFinal / 2);
            }
        }    */
    }
}

public enum DamageType
{
    Normal,
    Arcane,
    Fire,
    Ice,
    Poison,
    Light,
    Dark,
}