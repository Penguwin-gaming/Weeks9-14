using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //declaring the variables that the player makes use of
    public int movement;
    public float positionY;
    public float positionX;

    //variables that relate to other important features
    public int enemyHits;
    public bool isDead;
    public int enemyStreak;
    public Image streakReward;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        movement = 3;
        positionY = 0;
        positionX = - 10;
    }

    // Update is called once per frame
    void Update()
    {
        //updates the players location
        Vector2 pos = transform.position;
        pos.y = positionY;
        pos.x = - 10;
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
        // activates the streak reward for the player when 15 kills in a streak is made
        if (enemyStreak == 15)
        {
            streakReward.gameObject.SetActive(true);
            enemyStreak = 0; 
        }
        // destroys the player when hit by a bullet
        if (isDead == true)
        {
            Destroy (gameObject);
        }
    }
}
