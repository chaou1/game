using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gc : MonoBehaviour
{
   public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("ground")) { Player.GetComponent<bm>().isGrounded = true; };

    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "ground") { Player.GetComponent<bm>().isGrounded = false; }

    }
    
}
