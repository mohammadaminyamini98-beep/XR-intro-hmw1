using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 30f; // degrees per second

    void Update()
    {
        // Rotate around the Y-axis using real time
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
