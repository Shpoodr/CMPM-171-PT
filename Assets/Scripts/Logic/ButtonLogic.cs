using UnityEngine;

public class buttonLogic : MonoBehaviour
{
    private upgradeData assignedData;
    public Player playerInstance;

    public void setUpgradeData(upgradeData data)
    {
        assignedData = data;
    }

    public void onClick()
    {
        playerInstance.applyUpgrade(assignedData);
        Time.timeScale = 1f;
        GameManager.instance.runUpgrades.enabled = false;
    }
}
