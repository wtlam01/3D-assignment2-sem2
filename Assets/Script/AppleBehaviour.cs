using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleBehaviour : MonoBehaviour
{
    public Animator apple;
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

      apple.SetTrigger("fall");

    }
   }
}
