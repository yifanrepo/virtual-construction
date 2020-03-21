using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 270;
	private float pitch = 13;
//	private float roll = 0.0f;

	// Update is called once per frame
	void Update()
	{

		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");
//		roll -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

	}
} 