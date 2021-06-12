
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float RestartDelay = 1f;
    public void endGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke(restart, RestartDelay);
        
        }
    
    }
    void restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
