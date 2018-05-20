using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour {

    Rigidbody rigidbody;
    public bool grounded = true;
    public float speed = 25f;
    public float jumpForce = 100f;

    // COLLIDING

    bool right = false;
    bool left = false;
    bool down = false;
    bool up = false;

    void Start() {
        transform.position = new Vector3(0, 0, 0);
        rigidbody = GetComponent<Rigidbody>();
	}

    void Update() {
        if (Input.GetKey(KeyCode.A) && !left || Input.GetKey(KeyCode.LeftArrow) && !left) {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            Debug.Log("A");
        }

        if (Input.GetKey(KeyCode.S) && !down || Input.GetKey(KeyCode.DownArrow) && !down) {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            Debug.Log("S");
        }

        if (Input.GetKey(KeyCode.D) && !right || Input.GetKey(KeyCode.RightArrow) && !right)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            Debug.Log("D");
        }

        if (Input.GetKey(KeyCode.W) && !up || Input.GetKey(KeyCode.UpArrow) && !up) {
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

    public void Colliding(string direction, bool state, Collider other)
    {
        if (state)
        {
            if (direction == "Left")
            {
                left = true;
            }
            else if (direction == "Right")
            {
                right = true;
            }
            else if (direction == "Down")
            {
                down = true;
            }
            else if (direction == "Up")
            {
                up = true;
            }
            else if (direction == "Feet")
            {
                grounded = true;
                if (other.gameObject.tag == "Moving" || other.gameObject.tag == "MovingSolid")
                {
                    Debug.Log("TRIGGERED !!!!");
                    transform.parent = other.transform;
                }
            }
        }
        else
        {
            if (direction == "Left")
            {
                left = false;
            }
            else if (direction == "Right")
            {
                right = false;
            }
            else if (direction == "Down")
            {
                down = false;
            }
            else if (direction == "Up")
            {
                up = false;
            }
            else if (direction == "Feet")
            {
                transform.parent = null;
            }
        }
    }
}