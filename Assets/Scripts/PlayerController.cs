using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // ---------------------------------
    // Variables
    // ---------------------------------

    [SerializeField] float speed;
    Rigidbody playerRb;

    // ---------------------------------
    // Functions
    // ---------------------------------

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Allo
        playerRb.AddForce(speed * transform.forward, ForceMode.Impulse);
    }
}
