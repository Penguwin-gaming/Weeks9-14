using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int movement;
    public int position;

    // Start is called before the first frame update
    void Start()
    {
        movement = 3;
        position = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // checks player input and moves the player a set amount
        // checks if the player is at the higest posible position or the lowest and does not read the input if the player tries to move lower or higher
        if (Input.GetKeyDown(KeyCode.W) && position < 2)
        {
            position = position + movement;
        }

        if (Input.GetKeyDown(KeyCode.S) && position > -2)
        {
            position = position - movement;
        }
    }
}
