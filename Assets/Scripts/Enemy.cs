using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //the speed of the enemies they spawn in with. alongside its hit detection and particle effect when hit
    public float enemySpeed = 2;
    public float timeAlive;
    public float maxTimeAlive;
    public SpriteRenderer sr;
    public Player player;
    public ParticleSystem hit;

    // Start is called before the first frame update
    void Start()
    {
        //the time the enemy stays alive
        maxTimeAlive = 9;
    }

    // Update is called once per frame
    void Update()
    {
        //makes the Enemy travel a set speed from the right to the left side of the screen, the same as the bullets
        Vector2 pos = transform.position;
        pos.x -= enemySpeed * Time.deltaTime;
        transform.position = pos;

        // the timer to destroy the enemy after a set time
        timeAlive += Time.deltaTime;

        // code taken from week 6 target practice to check if the player has hit the enemy with the mouse and plays a particle system
        // also destroys the enemy and increments the players score and kill streak
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                player.enemyHits += 1;
                player.enemyStreak += 1;
                hit.Play();
                Destroy(gameObject, 0.5f);
            }

        }

        // enemy will destroy itself after travelling too long off screen to prevent an overflow of objects in game
        if (timeAlive > maxTimeAlive)
        {
            Destroy(gameObject);
        }
    }
}
