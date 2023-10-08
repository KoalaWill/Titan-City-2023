using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D FoodBody;
    public Stage1Move PlayerMove;
    public Transform Outlook;
    public Logic Logic;
    public float origin_speed;

    
    void Start()
    {
        PlayerMove = GameObject.Find("Player").GetComponent<Stage1Move>();
        Outlook = GameObject.Find("Food").GetComponent<Transform>();
        Logic = GameObject.Find("Logic").GetComponent<Logic>();
        Outlook.position = new Vector3(1730, 158, 0);
        //Debug.Log($"Player position position set to {Outlook.position}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.gameObject.name == "Player") {
            Logic.TouchFood();
            if (Input.GetKeyDown(KeyCode.E)) {
                Logic.GrabFood();
                Outlook.position = new Vector3(859, 186, 0);
                //Outlook.localScale = new Vector3(12,12, 12);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        //PlayerMove.speed = origin_speed;    
    }

}
