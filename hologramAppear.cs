using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hologramAppear : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
		 gameObject.GetComponent<Renderer>().enabled = true;
	}
        if (Input.GetKeyDown(KeyCode.L)) {
		gameObject.GetComponent<Renderer>().enabled = false;
	}
    }
}
