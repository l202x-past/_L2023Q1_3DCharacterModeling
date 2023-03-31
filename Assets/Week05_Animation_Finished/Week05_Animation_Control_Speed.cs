using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week05_Animation_Control_Speed : MonoBehaviour
{
    Animator Anim;
    public string PlayKey, PauseKey;

    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) {
            if(Input.inputString.ToLower() == PlayKey.ToLower()) {
                Anim.speed = 1.0f;
            }
        }
        if (Input.anyKeyDown) {
            if(Input.inputString.ToLower() == PauseKey.ToLower()){
                Anim.speed = 0.0f;
            }
        }
    }
}
