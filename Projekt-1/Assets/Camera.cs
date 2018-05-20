using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public float cameraSpeed = 20f;

	void Update () {
        UnityEngine.Camera.main.transform.position = Vector3.Lerp(UnityEngine.Camera.main.transform.position, transform.position + Vector3.up*4 + Vector3.back*4, Time.deltaTime * cameraSpeed); 
	}
}
