using UnityEngine;

public class Gun : MonoBehaviour {

	public float range = 5;
	public float damage = 10;
	public float health = 50;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	public void Fire () {
		Vector3 direction;
		if(gameObject.name == "Player"){
			direction = Camera.main.ScreenPointToRay(Input.mousePosition).direction.normalized;
		}else{
			direction = transform.forward.normalized;
		}
		GameObject bullet = Instantiate(bulletPrefab, bulletSpawn);
		bullet.transform.parent = GameObject.Find("Bullets").transform;
		bullet.GetComponent<Rigidbody>().AddForce(direction * 20, ForceMode.VelocityChange);
		bullet.transform.Rotate(direction);
		Bullet script = bullet.GetComponent<Bullet>();
		script.gun = gameObject;
		script.range = range;
		script.damage = damage;
 	}

 	public void Hit (float damage) {
 		health -= damage;
 		if(health <= 0){
 			Die();
 		}
 	}

 	void Die () {
 		Destroy(gameObject);
 	}

}
