using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerCtrl playerCtrls;
    public Vector2 mvmt;
    public float verInput, horInput;
    public float moveAmount;

    // Start is called before the first frame update
    private void OnEnable()
    {
        if (playerCtrls == null) 
        {
            playerCtrls = new PlayerCtrl();
            playerCtrls.PlayerMvmt.movement.performed += i => mvmt = i.ReadValue<Vector2>();
        }
        playerCtrls.Enable();
    }
    private void OnDisable()
    {
        if (playerCtrls == null)
        {
            playerCtrls = new PlayerCtrl();
            playerCtrls.PlayerMvmt.movement.performed += i => mvmt = i.ReadValue<Vector2>();
        }
        playerCtrls.Disable();
    }
    public void HandleAllInput()
    {
        HandleMovementInput();
    }
    private void HandleMovementInput()
    {
        verInput = mvmt.y;
        horInput = mvmt.x;

        moveAmount = Mathf.Clamp01(Mathf.Abs(horInput+verInput));
        PlayerManager.instance.playerAnim.UpdateAnimatorValues(0, moveAmount);
    }
}
