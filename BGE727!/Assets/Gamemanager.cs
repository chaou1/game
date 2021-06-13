
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class Gamemanager : MonoBehaviour


{

    public GameObject gameover,restartbutton, menu;
    bool gameHasEnded = false;

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
            Time.timeScale = 0;
            
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
}
