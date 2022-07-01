using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    ScoreCounter scoreCounter;

    private Color currentColor = Color.green;

    public void CatchFruit(Color color)
    {
        if (color == currentColor)
        {
            scoreCounter.AddPoint();
            Debug.Log("Right");
        }
        else
        {
            scoreCounter.SubPoint();
            Debug.Log("Wrong");
        }
    }

    public void MissFruit(Color color)
    {
        if (color != currentColor)
        {
            Debug.Log("Right");
        }
        else
        {
            scoreCounter.SubPoint();
            Debug.Log("Wrong");
        }
    }
}
