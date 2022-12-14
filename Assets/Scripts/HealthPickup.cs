using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
   [SerializeField] private int healthAmount = 13;

   private void OnCollisionEnter(Collision collision)
   {
      GameObject collisionObject = collision.gameObject ;
      
      if (collision.gameObject.tag == "Player" && collisionObject.GetComponent<PlayerHealth>().currentHealth < 100)
      {
         collisionObject.GetComponent<PlayerHealth>().IncreaseHealth(healthAmount);
         FMODUnity.RuntimeManager.PlayOneShot ("event:/Pickups/Pickup Grab");
         Destroy(gameObject);
      }
      
      
   }
   
   
}
