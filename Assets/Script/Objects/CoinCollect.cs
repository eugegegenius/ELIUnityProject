using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinCollect : MonoBehaviour 
{
    public AudioSource coinFX;

    private void OnTriggerEnter(Collider other)
    
    {
        coinFX.Play();
        ScoreManaging.coinCount += 1;
        this.gameObject.SetActive(false);
    }

}
    
