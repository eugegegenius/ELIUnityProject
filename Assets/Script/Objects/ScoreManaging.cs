using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManaging : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int coinCount;

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
    }
}
