using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _speed;

    public float Health
    {
        get { return _health; }
        set { _health = value; }
    }

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
}
