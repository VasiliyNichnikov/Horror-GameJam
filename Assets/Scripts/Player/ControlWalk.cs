using UnityEngine;

[RequireComponent(typeof(PlayerWalk))]
public class ControlWalk : MonoBehaviour
{
    private PlayerWalk _walk;
    private Vector3 _directionWalk;
    private Vector3 _cameraViewingAngle;
    
    public static bool IsMovement { get; private set; }

    private void Start()
    {
        _walk = GetComponent<PlayerWalk>();
    }

    private void Update()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaZ = Input.GetAxis("Vertical");

        IsMovement = CheckMovement(deltaX, deltaZ);
        
        _directionWalk = new Vector3(deltaX, 0, deltaZ);
        if(!ActionStaticItem.IsActiveInteration)
        {
            _walk.Walking(_directionWalk);
        }
    }

    private bool CheckMovement(float deltaX, float deltaZ)
    {
        return deltaX != 0 || deltaZ != 0;
    }
}
