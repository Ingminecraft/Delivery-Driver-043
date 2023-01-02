using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float streerSpeed = 1f;
    [SerializeField] float Movespeed = 1f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // * Time.deltaTime
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * streerSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * Movespeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Movespeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Movespeed = boostSpeed;
        }
    }
}
