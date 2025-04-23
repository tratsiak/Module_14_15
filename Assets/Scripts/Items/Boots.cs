using UnityEngine;

public class Boots : Item
{
    [SerializeField] private float _speedToAdd;

    public override void Use(Character affectedObject)
    {
        affectedObject.Speed += _speedToAdd;

        Remove();
    }
}
