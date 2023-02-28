using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    // Time to wait before removing the pin if it's down
    public float removeDelay = 2.0f;

    // Flag to track if the pin has been knocked down
    private bool isKnockedDown = false;

    void Start()
    {
       
    }
    void OnCollisionEnter(Collision collision) {
    // Check if the collision was with the bowling ball
    if (collision.gameObject.CompareTag("BowlingBall")) {
            // Knock over the pin
        if (!isKnockedDown)
            {
            // Set the flag to true
            isKnockedDown = true;

            if (IsPinDown())
                {
                    // Wait for the specified delay before removing the pin
                    StartCoroutine(RemovePinAfterDelay());
                }
            }
        }
    }

    bool IsPinDown()
    {
        // Check if the pin is down by measuring the angle between the pin and the ground
        float angle = Vector3.Angle(transform.up, -Vector3.up);
        return angle > 45.0f;
    }

    IEnumerator RemovePinAfterDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(removeDelay);

        // Remove the pin from the scene
        Destroy(gameObject);
    }
}
