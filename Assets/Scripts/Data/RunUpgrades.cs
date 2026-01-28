using UnityEngine;

public enum runUpgradeType { Damage, Speed, Maxhealth, Health, AttackSpeed, Regen }

//template for all ingame upgrades
[CreateAssetMenu(fileName = "upgradeData", menuName = "ScriptableObjects/upgradeData")]
public class upgradeData : ScriptableObject
{
    public string upgradeName;
    public runUpgradeType type;
    public float value;
    public GameObject effectPrefab;
}
