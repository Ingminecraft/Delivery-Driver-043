using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery: MonoBehaviour
{
    [SerializeField] Sprite texasWithBox;
    [SerializeField] Sprite texasWithBook;
    [SerializeField] Sprite texasWithNuke;
    [SerializeField] Sprite texas;
    [SerializeField] float destoryDelay = 0.0f;
    bool hasPackage;
    bool hasNuke;
    bool hasBook;
    bool hasBox;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("63410043 Cheathamas Phaichan");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        //Package
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Pickup Box");
            hasPackage = true;
            hasBox = true;
            Destroy(other.gameObject, destoryDelay);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = texasWithBox;
        }

        if (other.tag == "Customer" && hasBox)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            hasBox = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = texas;
            Destroy(other.gameObject, destoryDelay);
        }
        // Nuke
        if (other.tag == "Nuke" && !hasPackage)
        {
            Debug.Log("Pickup Nuke");
            hasPackage = true;
            hasNuke = true;
            Destroy(other.gameObject, destoryDelay);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = texasWithNuke;
        }

        if (other.tag == "SetNuke" && hasNuke)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            hasNuke = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = texas;
            Destroy(other.gameObject, destoryDelay);
        }
        // Book
        if (other.tag == "Book" && !hasPackage)
        {
            Debug.Log("Pickup Book");
            hasPackage = true;
            hasBook = true;
            Destroy(other.gameObject, destoryDelay);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = texasWithBook;
        }

        if (other.tag == "SetBook" && hasBook)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            hasBook = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = texas;
            Destroy(other.gameObject, destoryDelay);
        }
    }
}
