using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_contoller : MonoBehaviour
{
     public Animator dog;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
   {

   }


   private void OnTriggerEnter(Collider other)
   {
    if(other.tag == "Player"){

      dog.SetTrigger("attack");

    }
   }
}
