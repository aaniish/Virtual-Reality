using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {
	
	private void UpdateWheelPoses()
	{
		UpdateWheelPose(Wheel1, Wheel1_T);
		UpdateWheelPose(Wheel6, Wheel6_T);
		UpdateWheelPose(Wheel3, Wheel3_T);
		UpdateWheelPose(Wheel4, Wheel4_T);
		UpdateWheelPose(Wheel5, Wheel5_T);
		UpdateWheelPose(Wheel2, Wheel2_T);
	}

	private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
	{
		Vector3 _pos = _transform.position;
		Quaternion _quat = _transform.rotation;

		_collider.GetWorldPose(out _pos, out _quat);
		_quat = _quat * Quaternion.Euler(new Vector3(0, 90, 0));

		_transform.position = _pos;
		_transform.rotation = _quat;


	}

	private void FixedUpdate()
	{

		UpdateWheelPoses();
	}

	private float m_horizontalInput;
	private float m_verticalInput;
	private float m_steeringAngle;

	public WheelCollider Wheel1, Wheel6;
	public WheelCollider Wheel3, Wheel4;
	public WheelCollider Wheel2, Wheel5;
	public Transform Wheel1_T, Wheel6_T;
	public Transform Wheel3_T, Wheel4_T;
	public Transform Wheel2_T, Wheel5_T;
	private Rigidbody rigid;

}