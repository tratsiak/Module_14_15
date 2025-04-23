using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private ParticleSystem _itemDisappearEffect;

    public abstract void Use(Character affectedObject);

    protected virtual void Remove()
    {
        //_itemDisappearEffect.Play();

        Destroy(gameObject);
    }
}
