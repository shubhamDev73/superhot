using UnityEngine;

public class Bullet : MonoBehaviour {

	[@HideInInspector]
	public float range = 100;
	[@HideInInspector]
	public float damage = 10;
	[@HideInInspector]
	public GameObject gun;

	private Vector3 initPos;

	void Start () {
		initPos = transform.position;
	}

	void FixedUpdate () {
		if((transform.position - initPos).magnitude > range)
			Destroy(gameObject);
	}

	void OnCollisionEnter (Collision col) {
		if(col.gameObject != gun){
			Gun script = col.transform.GetComponent<Gun>();
			if(script)
				script.Hit(damage);
			Destroy(gameObject);
		}
	}
}
