using UnityEngine;

public class Gun : MonoBehaviour {

	public float range = 10;
	public float damage = 10;
	public float health = 50;
	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	public void Fire () {
		Vector3 direction;
		if(gameObject.name == "Player"){
			// firing where mouse is
			direction = Camera.main.ScreenPointToRay(Input.mousePosition).direction.normalized;
		}else{
			direction = transform.forward.normalized;
		}
		GameObject bullet = Instantiate(bulletPrefab, bulletSpawn);
		bullet.GetComponent<Rigidbody>().AddForce(direction * 10, ForceMode.VelocityChange);
		bullet.transform.Rotate(direction);
		// initializing bullet parameters
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
