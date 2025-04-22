using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rotator))]
public class PlayerMoveController : MonoBehaviour
{
    private const string VerticalAxisName = "Vertical";
    private const string HorizontalAxisName = "Horizontal";

    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;

    private CharacterController _characterController;
    private Rotator _rotator;

    private float _deadZone = 0.1f;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _rotator = GetComponent<Rotator>();
    }

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));

        if (input.magnitude <= _deadZone)
            return;

        _characterController.Move(input * _speed * Time.deltaTime);
        _rotator.ProcessRotateTo(input.normalized, _rotationSpeed);
    }
}
