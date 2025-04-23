using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private GameObject _effectPrefab;

    public abstract void Use(Character affectedObject);

    protected virtual void Remove()
    {
        Instantiate(_effectPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
