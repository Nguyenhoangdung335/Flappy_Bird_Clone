using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
