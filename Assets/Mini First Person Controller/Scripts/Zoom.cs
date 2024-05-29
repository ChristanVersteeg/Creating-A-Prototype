using UnityEngine;

[ExecuteInEditMode]
public class Zoom : MonoBehaviour
{
    private Camera cam;
    public float defaultFOV = 60;
    public float maxZoomFOV = 15;
    [Range(0, 1)]
    public float currentZoom;
    public float sensitivity = 1;

    private void Awake()
    {
        // Get the camera on this gameObject and the defaultZoom.
        cam = GetComponent<Camera>();
        if (cam)
        {
            defaultFOV = cam.fieldOfView;
        }
    }

    private void Update()
    {
        // Update the currentZoom and the camera's fieldOfView.
        currentZoom += Input.mouseScrollDelta.y * sensitivity * .05f;
        currentZoom = Mathf.Clamp01(currentZoom);
        cam.fieldOfView = Mathf.Lerp(defaultFOV, maxZoomFOV, currentZoom);
    }
}
