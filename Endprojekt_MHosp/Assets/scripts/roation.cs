using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, (float)0.25, 0);
	}
}
