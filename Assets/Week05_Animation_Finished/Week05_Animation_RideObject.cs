using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week05_Animation_RideObject : MonoBehaviour
{
    Transform MovingObject;
    // Start is called before the first frame update
    void Start()
    {
        MovingObject = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPSController")
        {
            other.transform.SetParent(MovingObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            other.transform.SetParent(null);
        }
    }
}
