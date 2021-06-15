using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    // Start is called before the first frame update

    public bool Playerthere = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Playerthere = true && Input.GetButton("Interact")) {

            FindObjectOfType<dialogmanager>().bobstextE();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player")) {

            Playerthere = true;
        
        
        };
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag=="player")
        {

            Playerthere = false;


        };
    }

}   
