using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLengthPowerup : MonoBehaviour
{
    public GameObject pickupEffect;
    public float multiplier = 1.5f;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    private void Pickup(Collider2D player)
    {
        //Spawn Pickup effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Debug.Log("Pickup");

        RopeSystem ropeSystem = player.GetComponent<RopeSystem>();
        ropeSystem.ropeMaxDistance += 1f;

        //Apply effect to player


        //Remove
        Destroy(gameObject);
    }
}
