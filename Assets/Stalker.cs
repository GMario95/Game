using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalker : MonoBehaviour
{
	public float moveSpeed = 3.0f;
	public Transform player;

    // Update is called once per frame
    void Update()
    {
		transform.position = Vector3.MoveTowards(new Vector3(player.position.x, player.position.y, player.position.z));
	}
}
