using UnityEngine;

public class SineWaveRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 70f;
    [SerializeField] private float _amplitude = 0.3f;
    [SerializeField] private float _frequency = 3f;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        float yOffset = Mathf.Sin(Time.time * _frequency) * _amplitude;
        transform.position = new Vector3(_startPosition.x, _startPosition.y + yOffset, _startPosition.z);
    }
}
