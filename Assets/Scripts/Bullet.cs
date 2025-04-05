using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //the speed of the bullet
    public float bulletSpeed = 3;
    public float airTime;
    public float maxAirTime = 8;
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
        pos.x += bulletSpeed * Time.deltaTime;
        transform.position = pos;

        //checks how long the bullet has been flying through the air and if it flies too long(off the screen) will despawn
        airTime += Time.deltaTime;

        if (airTime > maxAirTime)
        {
            player.BulletDissapear(gameObject);
            Destroy(gameObject);
        }

    }
}
