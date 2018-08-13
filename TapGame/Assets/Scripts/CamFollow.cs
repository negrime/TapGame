using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

	public Transform target; // объект слежения
	

	private void LateUpdate()
	{
		// Позиция камеры
		transform.position = new Vector3(target.position.x + 3, target.position.y + 3.5f, target.position.z - 10);
	}
}
