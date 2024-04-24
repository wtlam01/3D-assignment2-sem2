using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesselBehaviour : MonoBehaviour
{
   // Reference to the vessel object
    public GameObject vessel;


    private bool insideVessel = false;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == vessel)
        {
            insideVessel = true;
            Debug.Log("Entered vessel");
        }
    }

    void OnTriggerExit(Collider other)
    {
      
        if (other.gameObject == vessel)
        {
            insideVessel = false;
            Debug.Log("Exited vessel");
        }
    }
}
