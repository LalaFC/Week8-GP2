using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public float SmoothSpeed;
    public Vector3 Offset;

    private void Start()
    {
        Player = PlayerManager.instance.player.transform;
    }
    private void FixedUpdate()
    {
        Vector3 DesiredPosition = Player.position - Offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed * Time.deltaTime);
        transform.position = smoothposition; 
    }
}
