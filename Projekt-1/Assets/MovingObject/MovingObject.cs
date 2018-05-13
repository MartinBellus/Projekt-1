using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {

    public float length = 8f;
    private Vector3 pos;

	// Use this for initialization
	void Start () {
        transform.GetChild(0).transform.position = transform.position - new Vector3(length / 2, 0, 0);
        pos = transform.GetChild(0).transform.position;  
    }
	
	// Update is called once per frame
	void Update () {
        transform.GetChild(0).transform.position = new Vector3(Mathf.PingPong(Time.time, length) + pos.x, transform.position.y, transform.position.z);
        Debug.DrawLine(pos, new Vector3(pos.x + length, pos.y, pos.z), Color.green);
    }
}

