using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //the speed of the enemies they spawn in with
    public float enemySpeed = 2;
    public float timeAlive;
    public float maxTimeAlive;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        maxTimeAlive = 9;
    }

    // Update is called once per frame
    void Update()
    {
        //makes the Enemy travel a set speed from the right to the left side of the screen, the same as the bullets
        Vector2 pos = transform.position;
        pos.x -= enemySpeed * Time.deltaTime;
        transform.position = pos;

        timeAlive += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                Destroy(gameObject, 0.5f);
            }

        }

        if (timeAlive > maxTimeAlive)
        {
            Destroy(gameObject);
        }
    }
}
