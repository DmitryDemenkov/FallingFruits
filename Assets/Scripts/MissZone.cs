using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissZone : MonoBehaviour
{
    [SerializeField]
    private GameController controller;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Fruit missedFruit = collision.gameObject.GetComponent<Fruit>();
        if (missedFruit != null)
        {
            controller.MissFruit(missedFruit.color);
            missedFruit.Remove();
        }
    }
}
