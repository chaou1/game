using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bobstext;

 
    void Start()
    {
        bobstext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void bobstextE(){
        bobstext.SetActive(true);
    
    }
    
}
