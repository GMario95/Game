using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
	public Vector3 offset;
	public float fieldOfView = 60.0f;
	private GameObject player;
	private Vector3 scrollOffset = new Vector3(0f, 0f, 0f);

	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void LateUpdate() {
		float mouseScroll = Input.GetAxis("Mouse ScrollWheel") * 20f;
		if (mouseScroll != 0f) {
			Camera.main.fieldOfView -= mouseScroll;
		}
		transform.position = player.transform.position + offset + scrollOffset;
	}

}
