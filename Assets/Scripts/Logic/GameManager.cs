using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player playerInstance;
    public MetaProgression mPData;
    public RunData runData;

    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI goldText;

    public List<upgradeData> allUpgrades;
    public buttonLogic[] upgradeButtons;

    public Canvas runUpgrades;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        if(healthText == null || goldText == null)
        {
            Debug.LogError("UI Text references are missing in GameManager!");
        }
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
        runData.maxHealth = 100f;
        runData.damage = 10f;
        runData.speed = 5f;
        SceneManager.LoadScene(0);
    }
//updating health and gold run UI
    public void uiUpdate()
    {
        if (runData == null) return;
        healthText.text = $"Health: {runData.currentHealth} / {runData.maxHealth}";
        goldText.text = $"Gold: {runData.currentGold}";
    }
//opens the on run upgrade menu
    public void openUpgradeMenu()
    {
        Time.timeScale = 0f;
        getUpgradesReady();
        runUpgrades.enabled = true;
    }
//shuffling upgrades and connecting them to button logic
    public void getUpgradesReady()
    {
        List<upgradeData> shuffledUpgrades = new List<upgradeData>(allUpgrades);
        for (int i = 0; i< upgradeButtons.Length; i++)
        {
            int randomIndex = Random.Range(0, shuffledUpgrades.Count);
            upgradeButtons[i].setUpButton(shuffledUpgrades[randomIndex]);   
            shuffledUpgrades.RemoveAt(randomIndex);
        }
    }
}
