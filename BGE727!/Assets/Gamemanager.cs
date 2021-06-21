
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class Gamemanager : MonoBehaviour


{

    public GameObject gameover, restartbutton, menu, Player;
   public bool gameHasEnded = false;

    void Start()
    {
        menu.SetActive(false);
        gameover.SetActive(false);
        restartbutton.SetActive(false);
       

    }
    public void endGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            menu.SetActive(true);
            gameover.SetActive(true);
            restartbutton.SetActive(true);
            Player.GetComponent<bm>().runspeed = 0;
            Player.GetComponent<bm>().horizontalmove = 0;
           
            
        }
    
    }
    public void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
    public void NextScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);


    }
    public void loadscene(int i)
    {

        SceneManager.LoadScene(i);

    }
}
