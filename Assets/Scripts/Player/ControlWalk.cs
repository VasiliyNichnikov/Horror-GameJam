using System;
using UnityEngine;

[RequireComponent(typeof(PlayerWalk))]
public class ControlWalk : MonoBehaviour
{
    private PlayerWalk _walk;
    private Vector3 _directionWalk;
    private Vector3 _cameraViewingAngle;

    private void Start()
    {
        _walk = GetComponent<PlayerWalk>();
    }

    private void Update()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaZ = Input.GetAxis("Vertical");

        _directionWalk = new Vector3(deltaX, 0, deltaZ);
        
        _walk.Walking(_directionWalk);
    }
}
