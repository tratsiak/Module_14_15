using TMPro;
using UnityEngine;

public class StatsMonitor : MonoBehaviour
{
    private const string HealthText = "Health: ";
    private const string SpeedText = "Speed: ";

    [SerializeField] private Player _player;

    [SerializeField] private TextMeshProUGUI _health;
    [SerializeField] private TextMeshProUGUI _speed;

    private void Update()
    {
        _health.text = HealthText + _player.Health;
        _speed.text = SpeedText + _player.Speed;
    }
}
