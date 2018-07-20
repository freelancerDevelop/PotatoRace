using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {

	Quaternion rotation;

	void Awake()
	{
		rotation = transform.rotation;
	}
	void Update()
	{
		transform.eulerAngles = new Vector3 (0, 0, 0);

	}
}
