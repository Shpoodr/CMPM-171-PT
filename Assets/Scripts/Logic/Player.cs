using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Player : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;

    public RunData runData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Movement");
        GameManager.instance.uiUpdate();
    }

    void Update()
    {
        trackHealth();
        movePlayer();

        if (Input.GetKeyDown(KeyCode.G))
        {
            runData.currentGold += 10;
            GameManager.instance.uiUpdate();
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            runData.currentHealth -= 100;
            GameManager.instance.uiUpdate();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            GameManager.instance.openUpgradeMenu();
        }
    }

    void movePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * runData.speed * Time.deltaTime;
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
                runData.damage += (float)upgrade.value;
                break;
            case runUpgradeType.Speed:
                runData.speed += (float)upgrade.value;
                break;
            case runUpgradeType.Maxhealth:
                runData.maxHealth += (float)upgrade.value;
                break;
            /*case runUpgradeType.Shockwave:
                //implement shockwave logic later
                break;*/
            case runUpgradeType.AttackSpeed:
                runData.attackSpeed += (float)upgrade.value;
                break;
            case runUpgradeType.Regen:
                runData.regen += (float)upgrade.value;
                break;
        }
    }
}
