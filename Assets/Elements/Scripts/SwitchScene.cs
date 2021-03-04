using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void SwitchToStart()
    {
        SceneManager.LoadScene(0);
    }
    public void SwitchToGame()
    {
        SceneManager.LoadScene(1);
    }
}
