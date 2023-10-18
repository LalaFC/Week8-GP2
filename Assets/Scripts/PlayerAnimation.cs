using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    //[Range(0, 15)]
    //public float speed;

    int horizontal, vertical;
    private void Awake()
    {
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }

    //damp time = blend time... ung 0.1f
    public void UpdateAnimatorValues(float horMove, float verMove)
    {
        if(PlayerManager.instance.isSprinting) 
        {
            horMove = 2;
        }
        PlayerManager.instance.PlayerAnimator.SetFloat(horizontal, horMove, 0.1f, Time.deltaTime);
        PlayerManager.instance.PlayerAnimator.SetFloat(vertical, verMove, 0.1f, Time.deltaTime);
    }


    /*
    void Update()
    {
        if (PlayerManager.instance.inputManager.mvmt != Vector2.zero)
        {
            MoveForward();
        }
        else
        {
            StopMvment();
        }
    }

    void MoveForward()
    {
        PlayerAnim.SetBool("isRunning", true);
    }
    void StopMvment()
    {
        PlayerAnim.SetBool("isRunning", false);
    }
    */
}
