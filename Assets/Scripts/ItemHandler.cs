using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHandler : MonoBehaviour
{
	public Item item;

    void Update()
    {
		transform.Rotate(new Vector3(0, 180, 0) * Time.deltaTime);
	}

	public void onPickup() {
		Destroy(gameObject);
	}
}
