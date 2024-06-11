using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private InputController inputController;

    private void Start()
    {
        GameController.Default.Finished += Stop;
        GameController.Default.Started += Move;
    }
    private void OnDestroy()
    {
        GameController.Default.Finished -= Stop;
        GameController.Default.Started -= Move;
    }

    public void Rotation(float angle)
    {        
        playerMovementController.Rotation(angle);
    }

    public void Move()
    {
        playerMovementController.Move();
    }
    public void Stop()
    {
        playerMovementController.Stop();
        inputController.enabled = false;
    }
}
