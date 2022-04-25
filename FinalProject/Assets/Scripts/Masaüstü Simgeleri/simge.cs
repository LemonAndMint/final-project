using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simge : MonoBehaviour
{
	public GameObject panel;
	private void OnMouseDown()
	{
		panel.SetActive(true);
	}
}
