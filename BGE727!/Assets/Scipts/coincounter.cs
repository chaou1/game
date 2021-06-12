using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincounter : MonoBehaviour
{

    public GameObject Player;
    public int value;
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
        if (other.CompareTag("coin")) {

            value = value + 1;
            Player.GetComponent<bm>().coins = value;
        }
    }

}
