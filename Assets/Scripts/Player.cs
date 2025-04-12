using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //declaring the variables that the player makes use of
    public int movement;
    public int positionY;

    //variables that relate to other important features
    public int enemyHits;
    public bool isDead;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
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

        if (isDead == true)
        {
            Destroy (gameObject);
        }
    }
}
