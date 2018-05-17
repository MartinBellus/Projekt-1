﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public float cameraSpeed = 10f;

	void Update () {
        UnityEngine.Camera.main.transform.position = Vector3.Lerp(UnityEngine.Camera.main.transform.position, transform.position + Vector3.up*2 + Vector3.back*10, Time.deltaTime * cameraSpeed); 
	}
}
