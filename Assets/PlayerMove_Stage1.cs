using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stage1Move : MonoBehaviour
{
    public Rigidbody2D Player;
    public Transform Outfit;
    public Animator Animator;
    public float speed = 350.0F;
    public bool grounded;

    // Start is called before the first frame update

    private void OnCollisionStay2D(Collision2D collision)
    {

    }
    void Start()
    {
        Animator.SetBool("Grounded", false);
        Player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        Outfit = GameObject.Find("Player").GetComponent<Transform>();
        Animator = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // UP:1, DOWN:2, LEFT:3, RIGHT:4, STOP:5
        // int moveStatus = 0;
        float vx = 0, vy = 0;


        // Moving
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            Debug.Log("Test");
            vy = -1;
        }
        else if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            vy = 1;
        }
        else
        {
            vy = 0;
        }
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            vx = -1;    
            Outfit.localScale = new Vector3(-100, 100, 100);
        }
        else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            vx = 1;
            UnityEngine.Debug.Log(vx);
            Outfit.localScale = new Vector3(100, 100, 100);
        }
        else
        {
            vx = 0;
        }

        vx *= (speed + Time.deltaTime);
        vy *= (speed + Time.deltaTime);
        
        Player.velocity = new Vector2(vx, vy);

        // Animation
        Animator.SetBool("Grounded", grounded);
        Animator.SetFloat("Speedx", Mathf.Abs(Player.velocity.x));

        // Debug Log
        // Debug.Log($"g {grounded}");
        //Debug.Log($"S: {Input.GetKey(KeyCode.S)}");
    }

    public void Grounded()
    {
        Debug.Log(grounded);
        grounded = true;
    }

    public void NotGrounded()
    {

        grounded = false;
        
    }

    public void TouchFood()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            
        }
    }
}