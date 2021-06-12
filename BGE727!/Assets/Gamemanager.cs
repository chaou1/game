
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour

    
{
    bool gameHasEnded = false;
    public void endGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Restart();
        
        }
    
    }
    void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextScene()
    {

        SceneManager.LoadScene(1);


    }
}
