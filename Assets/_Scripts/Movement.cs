using UnityEngine;

public class Movement : MonoBehaviour {

	private static float speed = 10;
	private static float rotLimit = 20;

	void Update () {
		//move and rotate
		transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed, Space.Self);
		transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
		transform.GetChild(0).Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
		Vector3 angles = transform.GetChild(0).localEulerAngles;
		transform.GetChild(0).localEulerAngles = new Vector3(angles[0] > 180 ? Mathf.Clamp(angles[0], 270 + rotLimit, 360) : Mathf.Clamp(angles[0], 0, 90 - rotLimit), angles[1], angles[2]);

		//managing time
		if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
			Time.timeScale = 1;
		else
			Time.timeScale = 0;

		//firing
		if(Input.GetButton("Fire"))
			Fire();
	}

	void Fire () {
		//fire
	}
}
