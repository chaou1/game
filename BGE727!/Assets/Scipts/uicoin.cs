using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uicoin : MonoBehaviour
{

    public static uicoin instance;
    public TextMeshProUGUI text;
   
    


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null) {

            instance = this;
        }   
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void changescore(int coins) {

        
        text.text = "X" + coins;
    }
        
    }

