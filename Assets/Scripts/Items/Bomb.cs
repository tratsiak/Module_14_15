using UnityEngine;

public class Bomb : Item
{
    [SerializeField] private float _forceMagnitude;
    [SerializeField] private float _timeToExplode;

    private Collider _bombCollider;

    private float _time;
    private bool _isDropped;

    private void Awake()
    {
        _bombCollider = GetComponent<Collider>();
    }

    private void Update()
    {
        if (_isDropped)
        {
            Remove();
        }
    }

    public override void Use(Character affectedObject)
    {
        transform.parent = null;
        _bombCollider.isTrigger = false;

        Vector3 direction = affectedObject.transform.forward + Vector3.up;
        Vector3 normalizedDirection = direction.normalized;

        Drop(normalizedDirection);
    }

    protected override void Remove()
    {
        _time += Time.deltaTime;

        if (_time >= _timeToExplode)
        {
            base.Remove();
        }
    }

    private void Drop(Vector3 dropDirection)
    {
        Rigidbody _rigidbody = gameObject.AddComponent<Rigidbody>();
        _rigidbody.AddForce(dropDirection * _forceMagnitude, ForceMode.Impulse);

        _isDropped = true;
    }
}
