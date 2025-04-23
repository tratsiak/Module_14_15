using UnityEngine;

public class Medical : Item
{
    [SerializeField] private float _healthToAdd;

    public override void Use(Character affectedObject)
    {
        affectedObject.Health += _healthToAdd;

        Remove();
    }
}
