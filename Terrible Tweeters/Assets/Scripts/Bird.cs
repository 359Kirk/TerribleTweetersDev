using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.Red;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = Color.White;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
