using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
		 gameObject.GetComponent<VolumetricLight>().enabled = true;
	}
        if (Input.GetKeyDown(KeyCode.L)) {
		 gameObject.GetComponent<VolumetricLight>().enabled = false;
	}
    }
}
