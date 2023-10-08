using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class arrowMovement : MonoBehaviour
{
    public Text text;
    public float sita;
    public float R;
    public int T;
    private float x_pos;
    private float y_pos;
    private float z_pos;
    private RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    { 
        rectTransform = text.GetComponent<RectTransform>();
        x_pos = rectTransform.localPosition.x;
        y_pos = rectTransform.localPosition.y;
        z_pos = rectTransform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.deltaTime >= T / 360) sita++;
        rectTransform.localPosition = new Vector3(x_pos, y_pos + (float)(R * Math.Cos(2*Math.PI/T*sita)), z_pos);
    }
}
