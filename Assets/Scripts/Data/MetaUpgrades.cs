using UnityEngine;

//template for the permanent skill tree upgrades
public enum metaUpgradeType {}
[CreateAssetMenu(fileName = "MetaUpgrades", menuName = "Scriptable Objects/MetaUpgrades")]
public class MetaUpgrades : ScriptableObject
{
    public string upgradeName;
    public metaUpgradeType type;
    public int cost;
    public float value;
}
