using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private Animator animator;
        

    public void Move()
    {
        animator.SetBool("Move", true);
    }

    public void Dance()
    {
        animator.SetBool("Dance", true);
    }
}
