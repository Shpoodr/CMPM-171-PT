using UnityEngine;

[CreateAssetMenu(fileName = "RunData", menuName = "Scriptable Objects/RunData")]
public class RunData : ScriptableObject
{
    public list <upgradeData> upgrades = new list<upgradeData>();

    public int currentGold;
    public int totalGold;
}
