using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //the speed of the bullet and the amount of time the bullet can fly through
    public float bulletSpeed = 3;
    public float airTime;
    public float maxAirTime = 9;
    public Shooter shooter;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //makes the bullet travel a set speed from the left of the screen to the right
        Vector2 pos = transform.position;
        pos.x -= bulletSpeed * Time.deltaTime;
        transform.position = pos;

        if (pos.x <= player.positionX + 0.25 && pos.x >= player.positionX - 0.25 && pos.y >= player.positionY - 0.25 && pos.y <= player.positionY)
        {
            player.isDead = true;
        }

        //checks how long the bullet has been flying through the air and if it flies too long(off the screen) will despawn
        airTime += Time.deltaTime;

        if (airTime > maxAirTime)
        {
            shooter.BulletDissapear(gameObject);
            Destroy(gameObject);
        }
    }
}
