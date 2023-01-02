using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("63410043 Cheathamas Phaichan");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("What was that?");
    }
}
