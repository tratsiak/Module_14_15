using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Transform _colletedItemPoint;

    private Item _item;

    private void OnTriggerEnter(Collider other)
    {
        if (_item == null)
        {
            _item = other.GetComponent<Item>();

            if (_item != null)
            {
                _item.transform.parent = transform;
                _item.transform.position = _colletedItemPoint.position;
            }
        }
    }
}
