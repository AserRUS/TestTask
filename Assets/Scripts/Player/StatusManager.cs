using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StatusManager : MonoBehaviour
{
    [Serializable] 
    public class PlayerStatus
    {
        public string statusName;
        public float statusValue;
        public GameObject playerStatusSkin;
    }

    [SerializeField] private Slider slider;
    [SerializeField] private Text text;
    [SerializeField] private PlayerStatus[] playerStatus;

    private float _statusValue;
    private int playerStatusindex;
    private void Start()
    {
        slider.maxValue = 0;

        for (int i = 0; i < playerStatus.Length; i++)
        {
            slider.maxValue += playerStatus[i].statusValue;
        }
        
        _statusValue = 0;
        slider.value = _statusValue;
        text.text = playerStatus[playerStatusindex].statusName.ToString();
    }

    public void AddStatusValue(float value)
    {
        _statusValue += value;
        slider.value = _statusValue;
        StatusChange();
    }
    public void RemoveStatusValue(float value)
    {
        _statusValue -= value;
        slider.value = _statusValue;
        StatusChange();
    }

    private void StatusChange()
    {
        if (_statusValue >= playerStatus[playerStatusindex].statusValue)
        {
            if (playerStatusindex == playerStatus.Length - 1) return;
            playerStatusindex++;
        }
        if (_statusValue < playerStatus[playerStatusindex].statusValue)
        {
            if (playerStatusindex == 0) return;
            playerStatusindex--;
        }

        for (int i = 0; i < playerStatus.Length; i++)
        {
            playerStatus[i].playerStatusSkin.SetActive(false);
        }
        playerStatus[playerStatusindex].playerStatusSkin.SetActive(true);
        text.text = playerStatus[playerStatusindex].statusName.ToString();
    }
}
