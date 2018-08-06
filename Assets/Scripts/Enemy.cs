using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;
    public float life;
    public float attackForce;
    public Vector3 target;

	// Use this for initialization
	void Start () {
        target = new Vector3(transform.position.x, Camera.main.ViewportToWorldPoint(new Vector2(0,0)).y, transform.position.z);
	}
	
	

    internal void receiveSpellDamage(float damage)
    {
        life -= damage;
    }
}
