using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    [Header("Input Action Asset")]
    [SerializeField] private InputActionAsset inputActions;

    private InputAction moveAction;

    public Vector2 MoveInput { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        SetupInputActions();
    }

    private void SetupInputActions()
    {
        var playerMap = inputActions.FindActionMap("Player");

        moveAction = playerMap.FindAction("Move");

        moveAction.Enable();
    }

    private void Update()
    {
        MoveInput = moveAction.ReadValue<Vector2>();
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void OnDisable()
    {
        moveAction?.Disable();
    }
}
