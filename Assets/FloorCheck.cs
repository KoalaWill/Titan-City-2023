using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheck : MonoBehaviour
{
    public Stage1Move playerMove;
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        playerMove = GameObject.Find("Player").GetComponent<Stage1Move>();
        Animator = GameObject.Find("Player").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerMove.Grounded();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerMove.NotGrounded();
    }
}
