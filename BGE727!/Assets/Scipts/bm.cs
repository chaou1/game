using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class bm : MonoBehaviour
{


    public int coins;
    public float movementspeed;
    public float jumpstrength;

    public bool isGrounded = false;
    GameObject Player;
 






    // Start is called before the first frame updat
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
        if (Input.GetButton("Jump") && isGrounded == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpstrength), ForceMode2D.Impulse);



        }

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
}


