//Created by Tyson Frederick, 8/9/2014, while learning from Unity3D.com.

using UnityEngine;
using System.Collections;

public class TargetDamage : MonoBehaviour {

	public int hitPoints = 2;
	public Sprite damagedSprite;
	public float damageImpactSpeed;

	private int currentHitPoints;
	private float damageImpactSpeedSqr;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent <SpriteRenderer> ();
		currentHitPoints = hitPoints;
		damageImpactSpeedSqr = damageImpactSpeed * damageImpactSpeed;
			}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D collision){
		if (collision.collider.tag != "Damager")
						return;
		if (collision.relativeVelocity.sqrMagnitude < damageImpactSpeedSqr)
			return;

		spriteRenderer.sprite = damagedSprite;
		currentHitPoints --;

		if (currentHitPoints <= 0)
			Kill ();
	}

	void Kill () {
		//spriteRenderer.enabled = false;
		collider2D.enabled = false;
		rigidbody2D.isKinematic = true;
	}
}
