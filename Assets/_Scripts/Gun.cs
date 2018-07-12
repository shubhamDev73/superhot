using UnityEngine;

public class Gun : MonoBehaviour {

	public float range = 100;
	public float damage = 10;
	public float health = 50;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	public void Fire () {
		GameObject bullet = Instantiate(bulletPrefab, bulletSpawn);
		if(gameObject.name == "Player"){
			bullet.GetComponent<Rigidbody>().AddForce(Camera.main.ScreenPointToRay(Input.mousePosition).direction * 100, ForceMode.VelocityChange);
		}else{
			bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 100, ForceMode.VelocityChange);
		}
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
