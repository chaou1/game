using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvlmanager : MonoBehaviour
{
    public GameObject start,back, options, exit, level, lvl1, lvl2, lvl3;
    // Start is called before the first frame update
    void Start()
    {
        back.SetActive(false);
        lvl1.SetActive(false);
        lvl2.SetActive(false);
        lvl3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void Leverscreen()
    {
        start.SetActive(false);
        options.SetActive(false);
        exit.SetActive(false);
        level.SetActive(false);
        lvl1.SetActive(true);
        lvl2.SetActive(true);
        lvl3.SetActive(true);
        back.SetActive(true);




    }
    public void Mainscreen()
    {
        start.SetActive(true);
        options.SetActive(true);
        exit.SetActive(true);
        level.SetActive(true);
        lvl1.SetActive(false);
        lvl2.SetActive(false);
        lvl3.SetActive(false);
        back.SetActive(false);




    }

}
