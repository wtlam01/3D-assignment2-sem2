using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearBehaviour : MonoBehaviour
{
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
            animator.SetBool("sleep",true);
        
         }

}
}