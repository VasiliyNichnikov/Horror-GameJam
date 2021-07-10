using UnityEngine;

public class PlayerRotationCamera : MonoBehaviour
{
    [SerializeField] private RotationAxes _axes;
    
    [SerializeField] private float _minimalVertical;
    [SerializeField] private float _maximumVertical;
    
    [Space] [SerializeField] private float _sensitivityX;
    
    private Transform _thisTransform;
    private float _rotationX, _rotationY;

    public RotationAxes Axes
    {
        get => _axes;
        set => _axes = value;
    }

    public float MinimalVertical
    {
        get => _minimalVertical;
        set => _minimalVertical = value;
    }
    
    public float MaximumVertical
    {
        get => _maximumVertical;
        set => _maximumVertical = value;
    }
    
    public float SensitivityX
    {
        get => _sensitivityX;
        set => _sensitivityX = value;
    } 
    
    private void Start()
    {
        _thisTransform = transform;
    }

    private void Update()
    {
        if (_axes == RotationAxes.MouseX)
        {
            MouseX();
        }else if (_axes == RotationAxes.MouseY)
        {
            MouseY();
        }
    }

    private void MouseX()
    {
        _thisTransform.Rotate(0, Input.GetAxis("Mouse X") * _sensitivityX, 0);
    }

    private void MouseY()
    {
        _rotationX -= Input.GetAxis("Mouse Y") * _sensitivityX;
        _rotationX = Mathf.Clamp(_rotationX, _minimalVertical, _maximumVertical);
        
        _rotationY = _thisTransform.localEulerAngles.y;
        
        _thisTransform.localEulerAngles =  new Vector3(_rotationX, _rotationY, 0);
    }
    
}