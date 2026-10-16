using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnCollisionDo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   private void OnTriggerEnter2D(Collider2D collision){
    Destroy(collision.gameObject);
    
   }
}
