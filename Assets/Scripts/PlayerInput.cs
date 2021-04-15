using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public InputAction Movement;
    private IGetMovementInput[] movers;

    private void OnEnable()
    {
        Movement.Enable();
        Movement.started += _ => GetInput();
        movers = GetComponents<IGetMovementInput>();
    }

    private void OnDisable()
    {
        Movement.Disable();
    }

    public void GetInput()
    {
        Vector2 direction = Movement.ReadValue<Vector2>();
        for (int i = 0; i < movers.Length; i++) movers[i].GiveInput(direction);
    }
}
