using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "RunData", menuName = "Scriptable Objects/RunData")]
//holds on to current run data ex: health or coins and the current upgrades that have bee picked

public class RunData : ScriptableObject
{
    public List<upgradeData> upgrades = new List<upgradeData>();

    public int currentHealth;
    public int currentGold;
}
