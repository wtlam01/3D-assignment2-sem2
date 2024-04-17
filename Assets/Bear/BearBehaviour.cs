using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearBehaviour : MonoBehaviour
{
    public Animator bear;
      public AudioClip bearRoar;
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

      bear.SetTrigger("Attack");
      gameObject.GetComponent<AudioSource>().PlayOneShot(bearRoar);

    }
   }
}

