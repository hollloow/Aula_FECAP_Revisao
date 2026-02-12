using System;
using UnityEngine;

public class Player_Behavior : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private InputControls inputControls;
    private Vector2 inputDirector => inputControls.Player.Move.ReadValue<Vector2>();

    private void Awake()
    {
        inputControls = new InputControls();
        inputControls.Enable();
    }

    private void Update()
    {
        transform.Translate(inputDirector.x * moveSpeed * Time.deltaTime,0,inputDirector.y * moveSpeed * Time.deltaTime);
    }

    private void OnDestroy()
    {
        inputControls.Disable();
    }

    private void OnDisable()
    {
        inputControls.Disable();
    }
}
