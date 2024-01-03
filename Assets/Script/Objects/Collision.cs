using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            charModel.GetComponent<Animator>().Play("Stumble Backwards 1");
            StartCoroutine(ShowText());
            StartCoroutine(MoveAgain());
        }
        
    }

    IEnumerator ShowText()
    {
       text.SetActive(true); 
       yield return new WaitForSeconds(3);
       text.SetActive(false); 
    }

    IEnumerator MoveAgain()
    {
        yield return new WaitForSeconds(3);
        charModel.GetComponent<Animator>().Play("Standard Run");
        this.gameObject.SetActive(false);
        thePlayer.GetComponent<PlayerMove>().enabled = true;
    }
}
