using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mainmenu()
    {
        FindObjectOfType<Gamemanager>().MainMenu();
        Time.timeScale = 1;
    }
}
