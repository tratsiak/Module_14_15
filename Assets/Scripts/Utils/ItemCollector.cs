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
                SineWaveRotator rotator = _item.GetComponent<SineWaveRotator>();
                
                if (rotator != null)
                    Destroy(rotator);

                _item.transform.parent = transform;
                _item.transform.position = _colletedItemPoint.position;
                _item.transform.rotation = transform.rotation;
            }
        }
    }
}
