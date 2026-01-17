using UnityEngine;

public class XRViewSwitcher : MonoBehaviour
{
    [Header("View Points")]
    [SerializeField] private Transform roomViewPoint;
    [SerializeField] private Transform externalViewPoint;

    private bool isOutside = false;

    void Start()
    {
        // Start inside the room
        transform.position = roomViewPoint.position;
        transform.rotation = roomViewPoint.rotation;
    }

    void Update()
    {
        // Temporary test input (keyboard)
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SwitchView();
        }
    }

    void SwitchView()
    {
        if (isOutside)
        {
            transform.position = roomViewPoint.position;
            transform.rotation = roomViewPoint.rotation;
        }
        else
        {
            transform.position = externalViewPoint.position;
            transform.rotation = externalViewPoint.rotation;
        }

        isOutside = !isOutside;
    }
}
