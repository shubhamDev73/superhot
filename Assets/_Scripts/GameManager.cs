using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject enemyPrefab;

	void Start () {
		for(int i = 0; i < Random.Range(10, 20); i++){
			GameObject enemy = Instantiate(enemyPrefab);
			enemy.transform.position = new Vector3(Random.Range(-20, 20), 0, Random.Range(-20, 20));
			enemy.GetComponent<Enemy>().speed = Random.value * 0.1f;
			Gun gun = enemy.GetComponent<Gun>();
			gun.damage = Random.Range(5, 10);
			gun.health = Random.Range(20, 50);
		}
	}
	
}
