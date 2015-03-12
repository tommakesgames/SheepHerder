using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
            Debug.Log("Pressing left");

        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0.0f, Input.GetAxis("Vertical") * speed * Time.deltaTime));

	}
}
