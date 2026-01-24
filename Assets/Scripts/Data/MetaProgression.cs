using UnityEngine;

public enum upgradeType { Health, Damage, speed} 

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class NewScriptableObjectScript : ScriptableObject
{
    public string upgradeName;
    public upgradeType type;
    public float value;
}
