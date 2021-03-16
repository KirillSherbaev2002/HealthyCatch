using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flare : MonoBehaviour
{
    public player Player;
    public void Set()
    {
        Player = FindObjectOfType<player>();
        Player.Flare();
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
