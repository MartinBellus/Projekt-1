using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider col)
    {
        //OPTIONAL Particle effect - Instantiate(PARTICLE,transform.position,Quaternion.identity);

        PlayerStats playerStats = col.GetComponent<PlayerStats>();

        playerStats.coins++;

        Destroy(gameObject);
    }
}
