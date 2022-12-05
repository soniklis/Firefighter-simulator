using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private PlayerMovement charController;

    void Awake()
    {
        charController = GetComponent<PlayerMovement>();
    }

    private void FixedUpdate()
    {
        // Get input values
        int vertical = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));
        int horizontal = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        bool jump = Input.GetKey(KeyCode.Space);
        charController.ForwardInput = vertical;
        charController.TurnInput = horizontal;
        charController.JumpInput = jump;
    }

}