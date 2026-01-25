using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player playerInstance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }
    private void Start()
    {
        Instantiate(Resources.Load("PlayerCharacter")).name = "PlayerCharacter";
    }

    public void LevelComplete(upgradeData upgrade)
    {
        playerInstance.applyUpgrade(upgrade);
    }
}
