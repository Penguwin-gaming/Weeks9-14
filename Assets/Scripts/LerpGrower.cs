using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpGrower : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0;
    public float maxSize = 1;
    public float t;
    public bool startGrowing;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
    }

    private void Update()
    {
        if (startGrowing == true)
        {
            Grow();
        }
    }

    public void StartGrowing()
    {
        t = 0;
        startGrowing = true;
    }
    // Update is called once per frame
    public void Grow()
    {
        //t += Time.deltaTime;

        if (t < 1)
        {
            t += Time.deltaTime;
            //t = 0;
        }
        else
        {
            startGrowing = false;
        }

        transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
        //transform.localScale = Vector3.Lerp(Vector3.one * minSize, Vector3.one * maxSize, curve.Evaluate(t));
    }
}
