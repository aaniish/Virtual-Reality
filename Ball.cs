using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	public Transform des;
	private int counter = 0;
	public Rigidbody ball;
	public GameObject shooter;
	public Transform target;

    void OnTriggerEnter(Collider _c) {

    	if(_c.gameObject.tag == "Ball" && counter < 6) {
    	    Destroy(_c.gameObject);
    		counter++;
    	}
        }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&counter<6&&counter>0)
        {
            
            Rigidbody clone;
            clone = Instantiate(ball, des.position, des.rotation);
            //can change angle by changing middle value
            clone.AddRelativeForce(new Vector3(0,30,-60), ForceMode.Impulse);
            counter--;
        }

    }
}

