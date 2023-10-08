using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class ProgressBar : MonoBehaviour
{

    public Slider slider;
    public UnityEngine.UI.Text textValue;
    public UnityEngine.UI.Image image;
    public bool showText;
    public int maxValue;
    public float progress;
    public float MinColor_R;
    public float MinColor_G;
    public float MinColor_B;
    public float MaxColor_R;
    public float MaxColor_G;
    public float MaxColor_B;
    private float del_R;
    private float del_G;
    private float del_B;
    void Start()
    {
        del_R = MaxColor_R - MinColor_R;
        del_G = MaxColor_G - MinColor_G;
        del_B = MaxColor_B - MinColor_B;
        slider.maxValue = maxValue;
        if (!showText) textValue.text = "";
    }

    void Update() {
        slider.value = progress / 100 * maxValue;
    }

    public void OnValueChanged (float value) {
        if (showText) textValue.text = Mathf.CeilToInt(value).ToString() + "%";
        float R = MinColor_R + del_R / 100 * progress;
        float G = MinColor_G + del_G / 100 * progress;
        float B = MinColor_B + del_B / 100 * progress;
        image.color = new Color(R, G, B, 1);
    }
}
