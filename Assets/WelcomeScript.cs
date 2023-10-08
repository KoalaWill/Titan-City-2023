using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WelcomeScript : MonoBehaviour {
    //Image logo;
    Button StartButton;
    Button OptionsButton;
    Button AboutButton;
    Dictionary<string, GameObject> Panels = new Dictionary<string, GameObject>();
    Dictionary<string, Button> BackButtons = new Dictionary<string, Button>();


    public void Start() {
        //logo = GameObject.Find("logo").GetComponent<Image>();
        StartButton = GameObject.Find("btn_start").GetComponent<Button>();
        OptionsButton = GameObject.Find("btn_options").GetComponent<Button>();
        AboutButton = GameObject.Find("btn_about").GetComponent<Button>();
        BackButtons.Add("options", GameObject.Find("btn_back_options").GetComponent<Button>());
        BackButtons.Add("about", GameObject.Find("btn_back_about").GetComponent<Button>());
        Panels.Add("index", GameObject.Find("index"));
        Panels.Add("options", GameObject.Find("options"));
        Panels.Add("about", GameObject.Find("about"));
        StartButton.onClick.AddListener(() => SwitchScene("StartingVideo"));
        OptionsButton.onClick.AddListener(() => { OpenPanel("options", true); });
        AboutButton.onClick.AddListener(() => { OpenPanel("about", true); });

        OpenPanel("index", true);

        foreach (Button btn in BackButtons.Values) {
            btn.onClick.AddListener(() => { OpenPanel("index", true); });
        }
    }

    private void SwitchScene(string SceneName) {
        Debug.Log($"Scene has been changed to {SceneName}");
        SceneManager.LoadScene(SceneName);
    }

    private void OpenPanel(string PanelName, bool state) {
        if (state) {
            foreach (GameObject p in Panels.Values) {
                p.SetActive(false);
            }
        }
        Panels[PanelName].SetActive(state);
        Debug.Log($"Status of Panel {PanelName} has been changed to {state}");
    }
}
