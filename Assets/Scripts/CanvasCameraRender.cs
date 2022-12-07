using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasCameraRender : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
    void Start()
    {
        cam = Camera.main;
        GetComponent<Canvas>().worldCamera = cam;
    }
}
