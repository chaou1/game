using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l3 : MonoBehaviour
{
    int i = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadscene3()
    {

        FindObjectOfType<Gamemanager>().loadscene(i);

    }
}
