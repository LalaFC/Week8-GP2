using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    private Vector3 direction; 
    private Transform _camera;
    private Vector3 moveVelocity, targetDir;

    private void Awake()
    {
        _camera = Camera.main.transform;
    }

    public void HandleAllMvment()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement () 
    {
        direction = _camera.forward * PlayerManager.instance.inputManager.verInput;
        direction = direction + _camera.right * PlayerManager.instance.inputManager.horInput;
        direction.Normalize();
        direction.y = 0;
        direction *= PlayerManager.instance.mvmtSpeed;
        moveVelocity = direction;
        PlayerManager.instance._rigidbody.velocity = moveVelocity;
    } 
    private void HandleRotation () 
    {
        if (PlayerManager.instance.inputManager.verInput != 0 || PlayerManager.instance.inputManager.horInput != 0) 
        {
            targetDir = Vector3.zero;
            targetDir = _camera.forward * PlayerManager.instance.inputManager.verInput;
            targetDir = targetDir + _camera.right * PlayerManager.instance.inputManager.horInput;
            targetDir.Normalize();
            targetDir.y = 0;

            if (targetDir == Vector3.zero) 
            {
                targetDir = transform.forward;
            }

            Quaternion targetRot = Quaternion.LookRotation(targetDir);
            Quaternion playerRot =
                    Quaternion.Slerp
                    (
                        transform.rotation, targetRot, PlayerManager.instance.rotSpeed
                    );
            transform.rotation = playerRot;
        }

    }
}
