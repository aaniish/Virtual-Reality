using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

	public Transform target;
	public float range = 20f;
	public float distance;
	public Transform shooter;




    // Start is called before the first frame update
   

    void Update() {
    	distance = Vector3.Distance(shooter.position,target.position);
        if (distance < range) {
            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            Vector3 rotation = lookRotation.eulerAngles;
            shooter.rotation = Quaternion.Euler(0f, rotation.y-200f, 0f);
        }
    		
    	

    }
    

}
