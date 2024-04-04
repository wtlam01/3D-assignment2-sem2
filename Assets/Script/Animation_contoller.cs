using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_contoller : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            animator.SetTrigger("attack");


        }
         if(Input.GetKeyDown(KeyCode.Alpha2)){
            animator.SetBool("defand",true);
        
    }
         if(Input.GetKeyDown(KeyCode.Alpha3)){
            animator.SetBool("defand",false);
           }
}
}