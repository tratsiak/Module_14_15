using UnityEngine;

public class Rotator : MonoBehaviour
{
    public void ProcessRotateTo(Vector3 direction, float rotationSpeed)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.RotateTowards(transform.localRotation, lookRotation, rotationSpeed);
    }
}
