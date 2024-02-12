using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mvt : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 mvt = Vector3.zero; // Initialize movement vector

        // Check for movement keys
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mvt += Vector3.right;
            rb.velocity = mvt * speed * Time.deltaTime; // Move right
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mvt += Vector3.left;
            rb.velocity = mvt * speed * Time.deltaTime; // Move left
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            mvt += Vector3.forward;
            rb.velocity = mvt * speed * Time.deltaTime; // Move forward
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            mvt += Vector3.back;
            rb.velocity = mvt * speed * Time.deltaTime; // Move backward
        }

        

        
    }

     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("cherry"))
        {
            // Deactivate the cherry
            collision.gameObject.SetActive(false);
            
            
        }
    }
}
