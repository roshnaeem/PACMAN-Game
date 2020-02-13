using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pacDot : MonoBehaviour
{
    public static int score;
    public Text gScore;
    void Start()
    {
        score = 0;
        gScore = GameObject.Find("Text").GetComponent<Text>();
    }
    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
            score++;
        gScore.text = score.ToString();
        Destroy(gameObject);
    }
}
