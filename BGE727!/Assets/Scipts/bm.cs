using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class bm : MonoBehaviour
{

    public CharacterController2D controller;
    public int coins;
    public float runspeed = 40f;
    public float horizontalmove = 0f;
    public bool jump = false;
    public bool sprint = false;
    public Animator animator;

    GameObject Player;
 






    // Start is called before the first frame updat
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {if (
      Input.GetAxisRaw("sprint") > 0
            ) 
        {

            runspeed = 70f;
        
        
        
        }
        if (
          Input.GetAxisRaw("sprint") == 0
                )
        {

            runspeed = 40;



        }





        horizontalmove = Input.GetAxisRaw("Horizontal")* runspeed;
        if (Input.GetButtonDown("Jump")) 
        
        {

            jump = true;
       
        
        }
        animator.SetFloat("Speed",Mathf.Abs(horizontalmove));
    }
    void FixedUpdate()
    {
        controller.Move(horizontalmove * Time.fixedDeltaTime,false,jump);
        jump = false;
    }


        
    
private void OnCollisionEnter2D(Collision2D other)
{
    if (other.collider.CompareTag("death"))
    {

        FindObjectOfType<Gamemanager>().endGame();

    }

        if (other.collider.CompareTag("goal"))
    {

        FindObjectOfType<Gamemanager>().NextScene();

    }



}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("death"))
        {
            FindObjectOfType<Gamemanager>().endGame();

        }
    }
}


