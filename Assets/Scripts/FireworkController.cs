using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkController : MonoBehaviour
{

    public ParticleSystem fireWorks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fireWorks.gameObject.SetActive(!fireWorks.gameObject.activeInHierarchy);
        }

        if(Input.GetMouseButtonDown(0))
        {
            if(fireWorks.isPlaying == true)
            {
                fireWorks.Stop();
            }
            else
            {
                fireWorks.Play();
            }
        }
        
        if(Input.GetMouseButtonDown(1))
        {
            fireWorks.Emit(10);
        }
    }
}
