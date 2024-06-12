using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVFX : MonoBehaviour
{
    [SerializeField] private ParticleSystem moneyEffect;
    [SerializeField] private ParticleSystem alcoholEffect;

    public void MoneyEffect()
    {
        moneyEffect.Play();
    }
    public void AlcoholEffect()
    {
        alcoholEffect.Play();
    }
}
