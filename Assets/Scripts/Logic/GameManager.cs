using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player playerInstance;
    public MetaProgression mPData;
    public RunData runData;

    public Canvas runUpgrades;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }
    private void Start()
    {
        runUpgrades.enabled = false;
        Instantiate(Resources.Load("PlayerCharacter")).name = "PlayerCharacter";
    }

    public void LevelComplete(upgradeData upgrade)
    {
        playerInstance.applyUpgrade(upgrade);
    }

//death logic handling
    public void onDeath()
    {
        mPData.totalGold += runData.currentGold;
        Debug.Log("Total Meta Gold: " + mPData.totalGold);
        runData.currentGold = 0;
        runData.upgrades.Clear();
        runData.currentHealth = 100f;
    }
}
