using UnityEngine;

public class MovePlayerUnits : MonoBehaviour
{
    private Vector2 input;
    [SerializeField] private float playerUnitsSpeed;
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        input = InputManager.Instance.MoveInput;

        this.transform.Translate(0, 0, input.x * Time.deltaTime * playerUnitsSpeed);
    }
}
