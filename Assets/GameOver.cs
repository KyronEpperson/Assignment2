using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public static bool gameIsOver = false;
    public float restartDelay = 1f;

    public void endGame()
    {
        if (gameIsOver == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");

            //restart game
            loadQuitScene();
        }
    }

    void loadQuitScene ()
    {
        SceneManager.LoadScene(2);
    }
}
