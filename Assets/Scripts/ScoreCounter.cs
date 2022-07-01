using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;

    private int score;

    private void Start()
    {
        score = 0;
    }

    public void AddPoint()
    {
        score += 1;
        SetText();
    }

    public void SubPoint()
    {
        score -= 1;
        SetText();
    }

    private void SetText()
    {
        text.text = "—чет: " + score.ToString();
    }
}
