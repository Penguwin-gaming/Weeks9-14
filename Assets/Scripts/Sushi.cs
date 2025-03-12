using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sushi : MonoBehaviour
{
    public Image image;

    public Sprite highlight;
    public Sprite normal;

    public void MouseOn()
    {
        image.sprite = highlight;
    }

    public void MouseOff()
    {
        image.sprite = normal;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
