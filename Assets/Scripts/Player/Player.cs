using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private InputController inputController;
    [SerializeField] private PlayerVFX playerVFX;
    [SerializeField] private PlayerAnimationController playerAnimationController;
    [SerializeField] private StatusManager statusManager;

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
        playerAnimationController.Move();
    }
    public void Stop()
    {
        playerMovementController.Stop();
        inputController.enabled = false;
        playerAnimationController.Dance();
    }

    public void PickUpMoney(float value)
    {
        playerVFX.MoneyEffect();
        statusManager.AddStatusValue(value);
    }
    public void PickUpAlcohol(float value)
    {
        playerVFX.AlcoholEffect();
        statusManager.RemoveStatusValue(value);
    }
}
