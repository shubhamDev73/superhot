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
		if(timer > Random.Range(50, 100)){
			GetComponent<Gun>().Fire();
			timer = 0;
		}
	}
}
