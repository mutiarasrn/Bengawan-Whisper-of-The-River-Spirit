using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KemenyanPickup : MonoBehaviour
{
    [SerializeField] AudioClip KemenyanSFX;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            AudioSource.PlayClipAtPoint(KemenyanSFX, Camera.main.transform.position);
            Destroy(gameObject);
            Debug.Log("+10 points");
        }
    }
}
