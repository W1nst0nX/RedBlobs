using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraResoultion : MonoBehaviour
{
    public float defaultWidth;
    public float defaultHeight;

    void Start()
    {
        defaultWidth = Camera.main.orthographicSize * Camera.main.aspect;
        defaultHeight = Camera.main.orthographicSize;
    }

    void Update()
    {
        if(true) {
            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;
            Camera.main.orthographicSize = defaultHeight;
        }
    }
}
