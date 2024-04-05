using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
  
 public Animator box;
  public AudioClip boxmonster;
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

      box.SetTrigger("attack-box");

      gameObject.GetComponent<AudioSource>().PlayOneShot(boxmonster);

    }

     
   }
}
