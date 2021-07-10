using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float _speed;
    private CharacterController _character;

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }
    
    private void Start()
    {
        _character = GetComponent<CharacterController>();
    }

    /// <summary>
    /// Передвигает объект по заданному направлению
    /// </summary>
    /// <param name="movement"></param>
    public void Walking(Vector3 movement)
    {
        movement = Vector3.ClampMagnitude(movement, _speed);
        movement = transform.TransformDirection(movement);
        _character.Move(movement * _speed * Time.deltaTime);
    }

}
