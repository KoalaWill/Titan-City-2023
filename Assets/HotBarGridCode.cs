using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class HotBarGridCode : MonoBehaviour
{
    public List<GameObject> listOfSlots;
    private UnityEngine.UI.Image image;
    private float scrollDeltaY;
    public Sprite originalSprite;
    public Sprite newSprite;
    public int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {
            if (null == child)
                continue;
            listOfSlots.Add(child.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        index = ((int)(index + Input.mouseScrollDelta.y) % 8);
        for (int i = 0; i < listOfSlots.Count; i++)
        {
            image = listOfSlots[i].GetComponent<UnityEngine.UI.Image>();
            if (Input.GetKeyDown((i + 1).ToString()) == true || i == index)
            {
                index = i;
                image.sprite = newSprite;
                image.color = new Color(1, 1, 1, 1);
            }
            else if (i != index)
            {
                image.sprite = originalSprite;
                image.color = new Color((float)175 / 255, (float)171 / 255, (float)171 / 255, 1);
            }
            image.type = UnityEngine.UI.Image.Type.Sliced;
        }

    }
}