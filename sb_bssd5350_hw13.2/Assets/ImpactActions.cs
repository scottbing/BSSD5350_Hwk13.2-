using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactActions : MonoBehaviour                 
{
  public GameObject target;

  private void OnCTriggerEnter(Collider other)
  {
   target.GetComponent<CameraEffectScript>().activate = true; 
  }

  private void OnCollisionEnter(Collision collision)
  {
   target.GetComponent<CameraEffectScript>().activate = true; 
  }
}

