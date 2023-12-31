using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerCtrl playerCtrls;
    public Vector2 mvmt;
    public float verInput, horInput;
    public float moveAmount;
    public bool sprint_input;
    public bool walk_input;

    // Start is called before the first frame update
    private void OnEnable()
    {
        if (playerCtrls == null) 
        {
            playerCtrls = new PlayerCtrl();
            playerCtrls.PlayerMvmt.movement.performed += i => mvmt = i.ReadValue<Vector2>();
            playerCtrls.PlayerAction.Sprint.performed += i  => sprint_input = true;
            playerCtrls.PlayerAction.Sprint.canceled += i => sprint_input = false;
            playerCtrls.PlayerAction.Walk.performed += i => walk_input = true;
            playerCtrls.PlayerAction.Walk.canceled += i => walk_input = false;
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
        HandleSprinting();
        HandleWalking();
    }
    private void HandleMovementInput()
    {
        verInput = mvmt.y;
        horInput = mvmt.x;

        moveAmount = Mathf.Clamp01(Mathf.Abs(horInput+verInput));
        PlayerManager.instance.playerAnim.UpdateAnimatorValues(0, moveAmount);
    }

    private void HandleSprinting()
    {
        if (sprint_input && moveAmount > 0.5) 
        {
            PlayerManager.instance.isSprinting = true;
        }
        else
            PlayerManager.instance.isSprinting = false;
    }
    private void HandleWalking()
    {
        if (walk_input && moveAmount > 0.5)
        {
            PlayerManager.instance.isWalking = true;
        }
        else
            PlayerManager.instance.isWalking = false;
    }
}
