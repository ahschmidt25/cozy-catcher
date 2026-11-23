using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;

    void update()
    {
        Keyboard keyboard = Keyboard.current;
        if (keyboard == null) return;

        float direction = 0f;

        if (keyboard.leftArrowKey.isPressed || keyboard.aKey.isPressed)
            direction -= 1f;
        if (keyboard.rightArrowKey.isPressed || keyboard.dKey.isPressed)
            direction += 1f;

        transform.Translate(direction * moveSpeed * Time.deltaTime, 0f, 0f);
    }
}
