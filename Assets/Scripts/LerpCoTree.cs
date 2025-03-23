using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCoTree : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0;
    public float maxSize = 1;
    public float t;
    public Transform apple;

    private void Start()
    {
        t = 0;
        transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
        apple.localScale = Vector3.zero;
    }

    public void StartGrowing()
    {
        StartCoroutine(Grow());
    }

    IEnumerator Grow()
    {
        apple.localScale = Vector3.zero;
        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
            yield return null;
        }

        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            apple.localScale = Vector3.one * t;
            yield return null;
        }
    }
}
