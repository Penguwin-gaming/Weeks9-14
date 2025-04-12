using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public float shootTimer;
    public float time;
    public GameObject shot;
    public List<GameObject> bulletsOnScreen;
    public int maxBullets;

    // Start is called before the first frame update
    void Start()
    {
        maxBullets = 1;
        time = 0;
        shootTimer = Random.Range(4f, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > shootTimer && bulletsOnScreen.Count <= maxBullets)
        {
            Shoot();
            shootTimer = Random.Range(4f, 9f);
            time = 0;
        }
    }
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
