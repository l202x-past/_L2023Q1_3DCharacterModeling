using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week05_Animation_Control_Parameters : MonoBehaviour
{
    Animator Anim;
    public string PlayKey, PauseKey, ReverseKey;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat("Control", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.inputString.ToLower() == PlayKey.ToLower())
            {
                Anim.SetFloat("Control", 1f);
            }
        }
        if (Input.anyKeyDown)
        {
            if (Input.inputString.ToLower() == PauseKey.ToLower())
            {
                Anim.SetFloat("Control", 0f);
            }
        }
        if (Input.anyKeyDown)
        {
            if (Input.inputString.ToLower() == ReverseKey.ToLower())
            {
                Anim.SetFloat("Control", -1f);
            }
        }
    }
}
