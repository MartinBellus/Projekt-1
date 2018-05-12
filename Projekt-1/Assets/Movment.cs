using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour {

    Rigidbody rigidbody;
    bool grounded = true;
    public float speed = 25f;
    public float jumpForce = 100f;


    // Use this for initialization
    void Start() {
        transform.position = new Vector3(0, 0, 0);
        rigidbody = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            Debug.Log("A");
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            Debug.Log("S");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            Debug.Log("D");
        }

        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            Debug.Log("W");
        }

        if (Input.GetKey(KeyCode.Space)) {
            if (grounded) {
                rigidbody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                grounded = false;
                Debug.Log("Jump");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
}
