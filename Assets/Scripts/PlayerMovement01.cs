using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent (typeof (CharacterController))]
public class PlayerMovement01 : MonoBehaviour
{

    private CharacterController controller;
    [SerializeField] private float playerSpeed = 2.0f;
    private Vector2 _playerInput;

    public void playerMove(InputAction.CallbackContext context)
    {
        _playerInput = context.ReadValue<Vector2>();
    }

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(_playerInput.x,0,_playerInput.y);
        controller.Move(move * Time.deltaTime * playerSpeed);
    }
}
