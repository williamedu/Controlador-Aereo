using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoom : MonoBehaviour
{
    public float ZoomChange;
    public float SmoothChange;
    public float MinSize, MaxSize;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.mouseScrollDelta.y > 0)
            cam.orthographicSize -= ZoomChange * Time.deltaTime * SmoothChange;

        if (Input.mouseScrollDelta.y < 0)
            cam.orthographicSize += ZoomChange * Time.deltaTime * SmoothChange;

        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, MinSize, MaxSize);
    }
}
