using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 startpos;
    public Vector3 newpos;
    public float speed = 10f;
    float movespeed;
    public bool isrunningright = true;
    public Vector3 tempos;
    public Animator animator;
  
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
      



        newpos = startpos;
        newpos.x = newpos.x + speed * Mathf.PingPong(Time.time, 2) - 1;
        transform.position = newpos;

        if (newpos.x < tempos.x)
        {
            isrunningright = true;
        }
        else
        {
            isrunningright = false;
        }

        { }
    }
   public void dad()
    
    
    {
        animator.SetInteger("dying", 1);
        Destroy(this.gameObject);


    }



  
}
