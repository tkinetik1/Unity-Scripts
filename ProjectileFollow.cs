using UnityEngine;
using System.Collections;

public class ProjectileFollow : MonoBehaviour {

	public Transform Projectile;
	public Transform farLeft;
	public Transform farRight;

	void Update () {
		Vector3 newPosition = transform.position;
		newPosition.x = Projectile.position.x;
		newPosition.x = Mathf.Clamp (newPosition.x, farLeft.position.x, farRight.position.x);
		transform.position = newPosition;
	}
}
