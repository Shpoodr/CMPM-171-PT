using UnityEngine;

public enum upgradeType { Health, Damage, speed}

[CreateAssetMenu(fileName = "upgradeData", menuName = "Scriptable Objects/upgradeData")]
public class upgradeData : ScriptableObject
{
    public string upgradeName;
    public upgradeType type;
    public float value;
}
