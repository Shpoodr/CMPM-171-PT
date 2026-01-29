using UnityEngine;
using TMPro;

public class buttonLogic : MonoBehaviour
{
    private upgradeData assignedData;
    public Player playerInstance;

    [SerializeField] private TextMeshProUGUI buttonText;
    
    public void setUpButton(upgradeData data)
    {
        assignedData = data;
        buttonText.text = assignedData.upgradeName;

    }
    public void onClick()
    {
        Debug.Log("Button clicked for upgrade: " + assignedData.upgradeName);
        playerInstance.applyUpgrade(assignedData);
        Time.timeScale = 1f;
        GameManager.instance.runUpgrades.enabled = false;
    }
}
