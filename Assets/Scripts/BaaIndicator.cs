using UnityEngine;
using System.Collections;

public class BaaIndicator : MonoBehaviour {

    public GameObject sheep;
    public GameObject responder;


	// Use this for initialization
	void Start () {

        	
	}
	
	// Update is called once per frame
	void Update () {

        if (sheep.audio.isPlaying && !responder.audio.isPlaying)
            sheep.renderer.material.color = Color.black;

        if (!sheep.audio.isPlaying && !responder.audio.isPlaying)
            sheep.renderer.material.color = Color.white;

        if (responder.audio.isPlaying)
            sheep.renderer.material.color = Color.red;
	
	}
}
