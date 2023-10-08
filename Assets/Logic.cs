using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class Logic : MonoBehaviour
{
    public Objectives Obj = new Objectives();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Obj.objectivesProgress[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            Obj.objectivesProgress[0] = true;
        }
    }

    public void TouchFood()
    {
        Obj.objectivesProgress[1] = true;
    }
    public void GrabFood()
    {

        Obj.objectivesProgress[2] = true;
    }


}
