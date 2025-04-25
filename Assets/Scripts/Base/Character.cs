using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _speed;

    public float Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
                _health = 0;
            else
                _health = value;
        }
    }

    public float Speed
    {
        get { return _speed; }
        set
        {
            if (value < 0)
                _speed = 0;
            else
                _speed = value;
        }
    }
}
