using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public static Transform player;

	void Start () {
		if(!player)
			player = GameObject.Find("Player").transform;
	}

	void FixedUpdate () {
		transform.LookAt(player);
		transform.Translate(0, 0, 0.1f, Space.Self);
	}
}
