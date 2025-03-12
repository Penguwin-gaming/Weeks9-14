using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventsDemo : MonoBehaviour
{
    public RectTransform chicken;

    public UnityEvent onTimerFinished;
    public float timerLength = 2;
    public float t;

    private void Update()
    {
        if(t > timerLength)
        {
            onTimerFinished.Invoke();
            t = 0;
        }
        else
        {
            t += Time.deltaTime;
        }
    }
    public void MouseJustEntered()
    {
        Debug.Log("Mouse in range!!!");

        chicken.localScale = Vector3.one * 1.2f;
    }

    public void MouseJustExited()
    {
        Debug.Log("Mouse out of range!!!");
        chicken.localScale = Vector3.one;
    }

}
