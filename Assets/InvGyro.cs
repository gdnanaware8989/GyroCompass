using UnityEngine;
using System.Collections;

public class InvGyro : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	Gyroscope gyro = Input.gyro;
		gyro.enabled = true;
		transform.rotation = Quaternion.Inverse(gyro.attitude);
	}
}
