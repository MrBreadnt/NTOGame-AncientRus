using UnityEngine;
using System.Collections;

public class CameraFollow2D : MonoBehaviour
{

	public float damping = 1.5f;
	public Vector2 offset = new Vector2(0f, 0f);
	private Transform player;
	private int lastX;

	void Start()
	{
		offset = new Vector2(Mathf.Abs(offset.x), offset.y);
		FindPlayer();
	}

	public void FindPlayer()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
		lastX = Mathf.RoundToInt(player.position.x);
	}



	void Update()
	{
		if (player)
		{
			int currentX = Mathf.RoundToInt(player.position.x);
			lastX = Mathf.RoundToInt(player.position.x);

			Vector3 target;
			target = new Vector3(player.position.x, player.position.y, transform.position.z);
			Vector3 currentPosition = Vector3.Lerp(transform.position, target, damping * Time.deltaTime);
			transform.position = currentPosition;
		}
	}
}