using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l1 : MonoBehaviour
{


    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadscene1()
    {

        FindObjectOfType<Gamemanager>().loadscene(i);

    }
}
