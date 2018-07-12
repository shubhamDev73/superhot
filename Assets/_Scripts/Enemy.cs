using UnityEngine;

public class Enemy : MonoBehaviour {

	public static Transform player;
	private int timer;

	void Start () {
		timer = 0;
		if(!player)
			player = GameObject.Find("Player").transform;
	}

	void FixedUpdate () {
		transform.LookAt(player);
		transform.Translate(0, 0, 0.1f, Space.Self);
		timer++;
		if(timer > 30){
			Fire();
			timer = 0;
		}
	}

	void Fire () {
		//fire at player
	}
}
