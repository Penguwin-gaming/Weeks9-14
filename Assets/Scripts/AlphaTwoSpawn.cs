using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaTwoSpawn : MonoBehaviour
{

    public Vector2 mousePos;
    public GameObject tri;

    public CinemachineImpulseSource impulseSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate (tri, mousePos, Quaternion.identity);
            impulseSource.GenerateImpulse();
        }
    }
}
