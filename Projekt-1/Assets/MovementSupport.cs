using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSupport : MonoBehaviour {

    GameObject player;
    Movment m;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        m = player.GetComponent<Movment>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MovingSolid") || other.CompareTag("Solid"))
        {
            m.Colliding(gameObject.name, true, other);
            Debug.Log("Trig! >>");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MovingSolid") || other.CompareTag("Solid"))
        {
            m.Colliding(gameObject.name, false, other);
            Debug.Log("Trig! <<");
        }
    }
}
