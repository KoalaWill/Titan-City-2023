using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
//using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Objectives : MonoBehaviour
{
    public Text objectivesText;
    public string[] objectives;
    public bool[] objectivesProgress;
    private bool[] progressTemp;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateObjectivesText();
    }
    
    public void UpdateObjectivesText() {
        if (checkProgressChanged()) {
            objectivesText.text = "";
            for (int i = 0; i < objectives.Length; i++)
            {
                if (objectivesProgress[i] == false)
                {
                    objectivesText.text += "- " + objectives[i] + "\n";
                }
            }
            progressTemp = objectivesProgress;
        }
    }

    private bool checkProgressChanged()
    {
        bool changed = false;
        for (int i = 0; i < objectivesProgress.Length; i++)
        {
            if (!(objectivesProgress[i] && progressTemp[i]))
            {
                changed = true;
                return true;
                break;
            }
        }
        if (changed == false) return false;
        return false;
    }
}
