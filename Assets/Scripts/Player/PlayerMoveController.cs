using UnityEngine;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rotator))]
public class PlayerMoveController : MonoBehaviour
{
    private const string VerticalAxisName = "Vertical";
    private const string HorizontalAxisName = "Horizontal";

    private Player _player;
    private CharacterController _characterController;
    private Rotator _rotator;

    private float _deadZone = 0.1f;

    private void Awake()
    {
        _player = GetComponent<Player>();
        _characterController = GetComponent<CharacterController>();
        _rotator = GetComponent<Rotator>();
    }

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(HorizontalAxisName), 0, Input.GetAxisRaw(VerticalAxisName));

        if (input.magnitude <= _deadZone)
            return;

        _characterController.Move(input * _player.Speed * Time.deltaTime);
        _rotator.ProcessRotateTo(input.normalized, _player.Speed / 5f);
    }
}
