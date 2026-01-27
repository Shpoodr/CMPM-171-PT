using UnityEngine;
using System.Collections.Generic;
/*
Essentially a container for all meta progression data 
(no need to create assets for this SO)
*/

[CreateAssetMenu(fileName = "MetaUpgrades", menuName = "MetaUpgradeContainer/MetaUpgrades")]
public class MetaProgression : ScriptableObject
{
    public List<MetaUpgrades> upgrades = new List<MetaUpgrades>();
    public List<MetaUpgrades> unlockedCombos = new List<MetaUpgrades>();
    public int totalGold; 
}
