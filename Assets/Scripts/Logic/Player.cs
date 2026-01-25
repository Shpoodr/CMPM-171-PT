using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private float health = 100;
    private float damage = 10; 
    private float moveSpeed = 5;

    PlayerInput playerInput;
    InputAction moveAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Movement");
    }

    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * moveSpeed * Time.deltaTime;
    }
    //function for applying upgrade to the player taking an object from gameManager and reading data from metaProgression scriptable object 
    public void applyUpgrade(upgradeData upgrade)
    {
        switch (upgrade.type)
        {
            case runUpgradeType.Health:
                health += (float)upgrade.value;
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
