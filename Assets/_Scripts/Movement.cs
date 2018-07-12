using UnityEngine;

public class Movement : MonoBehaviour {

	void Start () {
		Time.timeScale = 0;
	}

	void Update () {
		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*10, 0, Input.GetAxis("Vertical")*Time.deltaTime*10, Space.Self);
		transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
		transform.GetChild(0).Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
		Vector3 angles = transform.GetChild(0).localEulerAngles;
		transform.GetChild(0).localEulerAngles = new Vector3(angles[0] > 180 ? Mathf.Clamp(angles[0], 290, 360) : Mathf.Clamp(angles[0], 0, 70), angles[1], angles[2]);
		if(Input.GetButton("Fire1"))
			Time.timeScale = 1 - Time.timeScale;
	}
}
