using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStop : MonoBehaviour
{
    public GameObject Screen;
    public int score;
    public GameObject player;

    void Update()
    {
       score = ScoreManaging.coinCount;
       if(score == 205) 
       {
        player.GetComponent<PlayerMove>().enabled = false;
        Screen.SetActive(true);
        if (Input.anyKey)
        {
            Application.Quit();
        }
       }
    }
}
