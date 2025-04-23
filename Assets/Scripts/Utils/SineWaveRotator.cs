using UnityEngine;

public class SineWaveRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 70f;
    [SerializeField] private float _amplitude = 0.3f;
    [SerializeField] private float _frequency = 3f;

    void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        Debug.Log(Mathf.Sin(Time.time));
        //float newY = Vector3.up.y + Mathf.Sin(Time.time * _frequency) / 10f * _amplitude; //рср ньхайю
        //transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
