using UnityEngine;
using System.Collections.Generic;
/*
holds on to current run data ex: health or coins and the current upgrades that have been picked
(no need to create assets for this SO)
*/
[CreateAssetMenu(fileName = "RunData", menuName = "Current run data/RunData")]

public class RunData : ScriptableObject
{
    public List<upgradeData> upgrades = new List<upgradeData>();
    public float currentHealth;
    public int currentGold;
}
