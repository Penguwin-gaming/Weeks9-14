using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //declaring the variables that the player makes use of
    public int movement;
    public int positionY;

    //variables that relate to bullets
    public GameObject shot;
    public int maxBullets = 5;
    public List<GameObject> bulletsOnScreen;
    public int enemyHits;
    public int killStreak;
    public Bullet bullet;
    public bool manyShots = false;

    // Start is called before the first frame update
    void Start()
    {
        movement = 3;
        positionY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //updates the players location
        Vector2 pos = transform.position;
        pos.y = positionY;
        transform.position = pos;
        // checks player input and moves the player a set amount (3 in this case) 
        // checks if the player is at the higest posible position or the lowest and does not read the input if the player tries to move lower or higher
        if (Input.GetKeyDown(KeyCode.W) && positionY < 2)
        {
            positionY = positionY + movement;
        }

        if (Input.GetKeyDown(KeyCode.S) && positionY > -2)
        {
            positionY = positionY - movement;
        }

        //checks if the player presses the space bar and calls on the shoot function to fire a bullet
        //will not shoot if the max amount of bullets on screen is reached
        if(Input.GetKeyDown(KeyCode.Space) && bulletsOnScreen.Count <= maxBullets)
        {
            Shoot();
        }

        //checks if the manyshots power is active and increases the max amount of bullets the player can fire
        if(manyShots == true)
        {
            maxBullets = 12;
        }
    }

    //the function that fires a bullet and adds the bullet to the list
    public void Shoot()
    {
        {
            GameObject bulletFired = Instantiate(shot, transform.position, transform.rotation);

            Bullet b = bulletFired.GetComponent<Bullet>();
            b.player = this;

            bulletsOnScreen.Add(bulletFired);
        }
    }

    //is called from the bullet script that removes the bullet after despawning or hitting an enemy
    public void BulletDissapear(GameObject b)
    {
        bulletsOnScreen.Remove(b);
    }
}
