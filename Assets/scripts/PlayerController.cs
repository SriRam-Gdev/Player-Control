using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
// This script controls the player movement in a Unity game using Rigidbody physics.

public class PlayerController : MonoBehaviour
{
    private float speed = 10f; 
    private Rigidbody PlayerMax;
    public float zbound = 6;// Speed of the player movement
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerMax = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        PlayerMax.AddForce(Vector3.right * speed * HorizontalInput);
        PlayerMax.AddForce(Vector3.forward * speed * VerticalInput);

        if (transform.position.z < -zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zbound);
        }
        if (transform.position.z > zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zbound);
        }
    }
}
