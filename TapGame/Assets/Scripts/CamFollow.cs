using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{


	public Transform target;
	void Start () 
	{
		
	}
	

	void Update () 
	{
		
	}

	private void LateUpdate()
	{
		transform.position = new Vector3(target.position.x + 3, target.position.y + 3, target.position.z - 10);
	}
}
