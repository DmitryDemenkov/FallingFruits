using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject circle;

    private double time;

    // Start is called before the first frame update
    void Start()
    {
        time = 1f;
        GameObject newCircle = Instantiate(circle, new Vector2(-2, 0), Quaternion.identity);
        newCircle.GetComponent<Rigidbody2D>().AddForce(new Vector2(1, 1), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        float[] xPosotions = { -3.5f, 3.5f };

        float currentXPosition = xPosotions[Random.Range(0, 2)];

        Vector2 position = new Vector2(currentXPosition, Random.Range(0.5f, 3.5f));

        int force = 2;
        if (currentXPosition > 0)
            force *= -1;

        time -= Time.deltaTime;
        if (time < 0)
        {
            GameObject newCircle = Instantiate(circle, position, Quaternion.identity);
            newCircle.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 4), ForceMode2D.Impulse);
            time = 1f;
        }

    }
}
