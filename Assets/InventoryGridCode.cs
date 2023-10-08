using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class InventoryGridCode : MonoBehaviour
{
    public bool GridClosed = true;
    public List<GameObject> listOfSlots;
    public UnityEngine.UI.Image image;
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
        GridClosed = true;
        foreach (Transform child in gameObject.transform)
        {
            if (null == child)
            continue;
            listOfSlots.Add(child.gameObject);
        }
        CloseTable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") == true)
        {
            image.enabled = !image.enabled;
            if (GridClosed == false)
            {
                CloseTable();
                GridClosed = true;
            }
            else
            {
                OpenTable();
                GridClosed = false;
            }
        }
    }

    public void CloseTable()
    {
        GameObject g;
        for(int i = 0; i < listOfSlots.Count; i++)
        {
            g = listOfSlots[i];
            UnityEngine.Debug.Log(g.name);
            g.SetActive(false);
        }
    }
    public void OpenTable()
    {
        GameObject g;
        for (int i = 0; i < listOfSlots.Count; i++)
        {
            g = listOfSlots[i];
            g.SetActive(true);
        }
    }    
}
