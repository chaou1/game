
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool gameHasEnded = false;
    public void endGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            restart();
        
        }
    
    }
    void restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
