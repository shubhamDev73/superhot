using UnityEngine;

public class Movement : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"), Space.Self);
		transform.Rotate(0, Input.GetAxis("Mouse X"), 0);
		transform.GetChild(0).Rotate(-Input.GetAxis("Mouse Y"), 0, 0);
		Vector3 angles = transform.GetChild(0).localEulerAngles;
		transform.GetChild(0).localEulerAngles = new Vector3(angles[0] > 180 ? Mathf.Clamp(angles[0], 290, 360) : Mathf.Clamp(angles[0], 0, 70), angles[1], angles[2]);
	}
}
