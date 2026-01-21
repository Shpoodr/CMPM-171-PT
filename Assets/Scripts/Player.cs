using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private int health = 100;
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
}
