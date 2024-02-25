using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!");
        
    } 

   void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Sungai") {
            Debug.Log("Avoid the River!");
        }
    } 
}
