using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsSpawner : MonoBehaviour
{
    [SerializeField]
    private GameController controller;

    [SerializeField]
    private GameObject[] circles;

    private float time = 1f;

    private float[] xPosotions = { -3.5f, 3.5f };
    private float[] yPositionRange = { 0.5f, 3.5f };
    private Vector2 force = new Vector2(0, 4);

    void Start()
    {
        InvokeRepeating(nameof(SpawnFruit), time, time);
    }

    private void SpawnFruit()
    {
        Vector2 currentPosition = new Vector2();
        currentPosition.x = xPosotions[Random.Range(0, 2)];
        currentPosition.y = Random.Range(yPositionRange[0], yPositionRange[1]);
        force.x = currentPosition.x < 0 ? 2 : -2;
        GameObject currentCurcle = circles[Random.Range(0, circles.Length)];

        GameObject newCircle = Instantiate(currentCurcle, currentPosition, Quaternion.identity);
        newCircle.GetComponent<Fruit>().controller = controller;
        newCircle.GetComponent<Rigidbody2D>().AddForce(force, ForceMode2D.Impulse);
    }
}
