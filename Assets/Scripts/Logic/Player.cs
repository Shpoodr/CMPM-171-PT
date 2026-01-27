using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Variables for player stats (temp)
    private float damage = 10; 
    private float moveSpeed = 5;

    [SerializeField]
    public Text healthText;
    [SerializeField]
    private Text goldText;
    
    PlayerInput playerInput;
    InputAction moveAction;

    public RunData runData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Movement");
    }

    void Update()
    {
        trackHealth();
        movePlayer();

        Input.GetKeyDown(KeyCode.G);
        Input.GetKeyDown(KeyCode.D);
        if (Input.GetKeyDown(KeyCode.G))
        {
            runData.currentGold += 10;
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            runData.currentHealth -= 100;
        }
    }

    void movePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * moveSpeed * Time.deltaTime;
    }

    void trackHealth()
    {
        //Debug.Log("Player says RunData is: " + runData);
        //if (runData == null) { Debug.LogError("RunData is missing!"); return; }
        //if (GameManager.instance == null) { Debug.LogError("GameManager Instance is missing!"); return; }
        if (runData.currentHealth <= 0)
        {
            Debug.Log("Player has died.");
            GameManager.instance.onDeath();
        }
    }
    //function for applying upgrade to the player taking an object from gameManager and reading data from metaProgression scriptable object 
    public void applyUpgrade(upgradeData upgrade)
    {
        switch (upgrade.type)
        {
            case runUpgradeType.Health:
                runData.currentHealth += (float)upgrade.value;
                break;

            case runUpgradeType.Damage:
                damage += (float)upgrade.value;
                break;
            
            case runUpgradeType.speed:
                moveSpeed += (float)upgrade.value;
                break;
        }
    }
}
