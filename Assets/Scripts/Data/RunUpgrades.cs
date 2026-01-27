using UnityEngine;

public enum runUpgradeType { Damage, speed, Shockwave, Maxhealth, Health }

//template for all ingame upgrades
[CreateAssetMenu(fileName = "upgradeData", menuName = "ScriptableObjects/upgradeData")]
public class upgradeData : ScriptableObject
{
    public string upgradeName;
    public runUpgradeType type;
    public float value;
    public GameObject effectPrefab;
}
