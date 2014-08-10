//Created by Tyson Frederick, 7/29/2014, with Official Project/Tutorial video from Unity3D.com;

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position;
	}

	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
