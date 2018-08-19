using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour {
    
    public float sensitivity = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float _mouseX = Input.GetAxis("Mouse X");
        Vector3 currentLoc = transform.localEulerAngles;
        currentLoc.y += _mouseX * sensitivity;
        transform.localEulerAngles = currentLoc;
	}
}
