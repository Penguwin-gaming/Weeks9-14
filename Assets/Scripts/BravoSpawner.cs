using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BravoSpawner : MonoBehaviour
{

    public GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnASquare()
    {
        Instantiate(square, Random.insideUnitCircle * 6, transform.rotation);
    }
}
