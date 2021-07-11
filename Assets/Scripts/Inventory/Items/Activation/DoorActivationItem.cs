using System;
using System.Collections;
using UnityEngine;

public class DoorActivationItem : Item
{
    [SerializeField] private float _minAngle;
    [SerializeField] private float _maxAngle;
    [SerializeField] private float _speed;
    private Transform _thisTransform;
    private bool _animationEnd;
    private bool _isOpen;

    private void Start()
    {
        _thisTransform = transform;
        _isOpen = false;
        _animationEnd = true;
    }

    public override void InteractionStaticAction(ParametersItem parameters)
    {
    }

    public override void DynamicAction()
    {
    }

    public override void ActivasionAction()
    {
        if (_animationEnd)
        {
            StartCoroutine(Animation(_isOpen));
        }
        
    }

    private IEnumerator Animation(bool back = false)
    {
        _animationEnd = false;

        _isOpen = !_isOpen;
        float pointEnd = _maxAngle;
        if (back)
            pointEnd = _minAngle;
        Quaternion end = Quaternion.Euler(0, pointEnd, 0);
        float angle = Quaternion.Dot(_thisTransform.rotation, end);
        
        while (angle < 1f)
        {
            _thisTransform.rotation = Quaternion.Slerp(_thisTransform.rotation, end, _speed * Time.deltaTime);
            yield return null;
            angle = Quaternion.Dot(_thisTransform.rotation, end);
        }

        _animationEnd = true;
    }
}