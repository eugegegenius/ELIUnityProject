using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextManaging : MonoBehaviour
{
    public int score;
    public GameObject panelText;
    public TextMeshProUGUI textWindow;
  

    // Start is called before the first frame update
    void Start()
    {
        panelText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score = ScoreManaging.coinCount;
        if (score == 10)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "Sometimes it feels like running is the only option.";
        }

        score = ScoreManaging.coinCount;
        if (score == 30)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "Like hundreds of dogs chase you as a prey.";
        }

        if (score == 50)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "You might be tired.";
        }

        if (score == 100)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "But you feel like you can't stop.";
        }

        if (score == 130)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "But ask yourself";
        }

        if (score == 150)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "What are you running from?";
        }

        if (score == 160)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "What are you running towards?";
        }

        if (score == 170)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "So stop for a moment and think...";
        }

        if (score == 180)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "Is it really worth running?";
        }

         if (score == 200)
        {
            StartCoroutine(textChange());
            textWindow.GetComponent<TextMeshProUGUI>().text = "" + "Is it time to turn around and face whatever you are runing from?";
        }
    }

    IEnumerator textChange()
    {
        panelText.SetActive(true);
        yield return new WaitForSeconds(5);
        panelText.SetActive(false);
    }
}