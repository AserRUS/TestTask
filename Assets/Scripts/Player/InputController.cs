using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private PlayerMovementController playerMovementController;

    private void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            mouseX = Mathf.Clamp(mouseX, -0.3f, 0.3f);
            playerMovementController.MouseX = mouseX;
        }
        if (Input.GetMouseButtonUp(0)) 
        {
            playerMovementController.MouseX = 0;
        }
    }
}
