using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance { get; private set; }
    [Header("Components")]
    public GameObject player;
    public Rigidbody _rigidbody;
    public Animator PlayerAnimator;

    [Header("Player Scripts")]
    public InputManager inputManager;
    public PlayerLocomotion locomotion;
    public PlayerAnimation playerAnim;

    [Header("State")]
    public float mvmtSpeed;
    public float rotSpeed;
    public float sprintSpeed;

    [Header("State")]
    public bool isSprinting;
    public bool isWalking;
    public bool isJumping;

    private void Awake()
    {
        if (instance != null && instance != this) { Destroy(this); }
        else { instance = this; }
        inputManager = player.GetComponent<InputManager>();
        locomotion = player.GetComponent<PlayerLocomotion>();
        playerAnim = player.GetComponent<PlayerAnimation>();
        PlayerAnimator = player.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.HandleAllInput();
    }

    private void FixedUpdate()
    {
        locomotion.HandleAllMvment();
    }
}
