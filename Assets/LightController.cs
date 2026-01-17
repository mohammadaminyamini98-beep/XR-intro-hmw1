using UnityEngine;

public class LightController : MonoBehaviour
{
    private UnityEngine.Light lightComponent;

    void Awake()
    {
        lightComponent = GetComponent<UnityEngine.Light>();

        if (lightComponent == null)
            Debug.LogError("No Light component found on this GameObject!", this);
        else
            Debug.Log("LightController ready. Press Tab.", this);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Debug.Log("Tab pressed!", this);
            lightComponent.color = new Color32(217, 16, 16, 255);
        }
    }
}
