using UnityEngine;
using System.Collections;

public class BaaIndicator : MonoBehaviour {

    public GameObject sheep;


	// Use this for initialization
	void Start () {

        	
	}
	
	// Update is called once per frame
	void Update () {

        if (sheep.audio.isPlaying)
            sheep.renderer.material.color = Color.black;

        if (!sheep.audio.isPlaying)
            sheep.renderer.material.color = Color.white;
	
	}
}
