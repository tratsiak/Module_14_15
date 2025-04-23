using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Item _itemPrefab;
    [SerializeField] private float _cooldown;

    private Item _spawnedItem;

    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _cooldown)
        {
            if (_spawnedItem != null)
            {
                if (IsOccupied())
                {
                    _time = 0;
                    return;
                }
            }

            SpawnItem();

            _time = 0;
        }
    }

    private void Start()
    {
        SpawnItem();
    }

    private void SpawnItem()
    {
        _spawnedItem = Instantiate(_itemPrefab, transform.position, Quaternion.identity);
        _spawnedItem.transform.parent = transform;
    }

    private bool IsOccupied()
    {
        return _spawnedItem.transform.parent == transform;
    }
}
