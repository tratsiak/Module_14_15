using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 70f;
    [SerializeField] private float _amplitude = 0.3f;
    [SerializeField] private float _frequency = 3f;

    private Vector3 _startPosition;

    void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        float newY = _startPosition.y + Mathf.Sin(Time.time * _frequency) * _amplitude;
        transform.position = new Vector3(_startPosition.x, newY, _startPosition.z);
    }
}
