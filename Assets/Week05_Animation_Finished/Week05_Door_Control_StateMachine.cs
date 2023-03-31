using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week05_Door_Control_StateMachine : MonoBehaviour
{
    public GameObject DoorContainer;
    Animator DoorContainerAnim;
    void Start()
    {
        DoorContainerAnim = DoorContainer.GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            DoorContainerAnim.SetInteger("Control", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "FPSController")
        {
            DoorContainerAnim.SetInteger("Control", 2);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "FPSController") {
            DoorContainerAnim.SetInteger("Control", 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "FPSController")
        {
            DoorContainerAnim.SetInteger("Control", 2);
        }
    }
}
