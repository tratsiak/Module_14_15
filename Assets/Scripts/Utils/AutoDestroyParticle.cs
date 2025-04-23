using UnityEngine;

public class AutoDestroyParticle : MonoBehaviour
{
    private ParticleSystem _particleSystem;

    private void Awake()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    void Start()
    {
        Destroy(gameObject, _particleSystem.main.duration);
    }
}
