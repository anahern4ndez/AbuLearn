using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements.StyleEnums;

public class ScrollingBackground : MonoBehaviour {
	public float scrollingSpeed = 5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (-1, 0, 0) * scrollingSpeed * Time.deltaTime);
		if (transform.position.x < -26.02f) {
			transform.position = new Vector3 (26.02f, transform.position.y, transform.position.z); 
		}
	}
}
