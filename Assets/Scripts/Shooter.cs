using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    // the variables that the shooter objects use to shoot their weapons
    public float shootTimer;
    public float time;
    public GameObject shot;
    public List<GameObject> bulletsOnScreen;
    public int maxBullets;

    // Start is called before the first frame update
    void Start()
    {
        // the max amount of bullets and the amount of time that must elapse before the object can shoot a bullet
        maxBullets = 1;
        time = 0;
        shootTimer = Random.Range(4f, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        //counts the timer and fires when the random range of time is met, then re randomizes the shoot timer
        time += Time.deltaTime;

        if (time > shootTimer && bulletsOnScreen.Count <= maxBullets)
        {
            Shoot();
            shootTimer = Random.Range(4f, 9f);
            time = 0;
        }
    }

    // a function that fires the bullet object and checks how many bullets has the individual shooter fired, it will stop the shooter
    // from shooting more than a set amount of bullets to prevent them from filling up the screen with bullets making it unfair for the player
    // code adapted from week 6 target practice to make a list of the bullets spawned but used to set a max amount of bullets that can be fired rather than checking if all targets have been shot
    public void Shoot()
    {
        GameObject bulletFired = Instantiate(shot, transform.position, transform.rotation);

        Bullet b = bulletFired.GetComponent<Bullet>();
        b.shooter = this;

        bulletsOnScreen.Add(bulletFired);
    }

    public void BulletDissapear(GameObject b)
    {
        bulletsOnScreen.Remove(b);
    }
}
