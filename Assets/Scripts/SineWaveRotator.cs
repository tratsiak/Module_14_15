using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 70f;
    [SerializeField] private float _amplitude = 0.3f;
    [SerializeField] private float _frequency = 3f;

    void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        float newY = transform.position.y + Mathf.Sin(Time.time * _frequency) / 10f * _amplitude; //��� ������
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
