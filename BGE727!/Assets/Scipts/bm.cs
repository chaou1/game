using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bm : MonoBehaviour
{


    public int coincounter;
public float movementspeed;
public float jumpstrength;
public bool isGrounded = false;
GameObject Player;






    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime * movementspeed;
        Jump();
    }


    
     void Jump()
        {
            if (Input.GetButton("Jump") && isGrounded == true
                   )
            {
               
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpstrength), ForceMode2D.Impulse);

             
            }



        }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("death")) {

            FindObjectOfType<Gamemanager>().endGame();
        
        }
    }



}
