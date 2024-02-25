using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerControl : MonoBehaviour
{

    [SerializeField] float kanankiri = 0.1f;
    [SerializeField] float majumundur = 0.1f;
    
    void Start()
    {

    }

    void Update()
    {
        
        float leftright = Input.GetAxis("Horizontal") * kanankiri * Time.deltaTime;
        float updown = Input.GetAxis("Vertical") * majumundur * Time.deltaTime;
        //transform.Rotate(0, 0, -leftright);
        transform.Translate(leftright, updown, 0);
        
        
    }

}
