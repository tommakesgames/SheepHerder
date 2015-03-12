using UnityEngine;
using System.Collections;

public class ResponseIndicator : MonoBehaviour {

    public GameObject sheep;
    public GameObject responder;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (responder.audio.isPlaying)
            sheep.renderer.material.color = Color.red;

        if (!responder.audio.isPlaying)
            sheep.renderer.material.color = Color.white;
	
	}
}
