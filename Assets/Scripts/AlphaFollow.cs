using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaFollow : MonoBehaviour
{
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.color = Random.ColorHSV();
        }
    }
}
