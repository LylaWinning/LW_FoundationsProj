using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickUpBox : MonoBehaviour 
{
    public Transform player;
    public float pickUpRange = 5f;
    public float throwForce = 10f;

    private bool isPickedUp = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float distance = Vector3.Distance(player.position, transform.position);
            if (distance <= pickUpRange)
            {
                isPickedUp = !isPickedUp;
                rb.isKinematic = isPickedUp;
                if (isPickedUp)
                {
                    transform.SetParent(player);
                    transform.localPosition = new Vector3(0, 1, 2); // Adjust position as needed
                }
                else
                {
                    transform.SetParent(null);
                    rb.linearVelocity = Vector3.zero; // Reset velocity when dropped
                }
            }
        }

        if (isPickedUp && Input.GetMouseButtonDown(0)) // Left mouse button to throw
        {
            isPickedUp = false;
            transform.SetParent(null);
            rb.isKinematic = false;
            rb.AddForce(player.forward * throwForce, ForceMode.Impulse);
        }
    }
 
}
