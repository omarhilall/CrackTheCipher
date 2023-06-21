using UnityEngine;

namespace HilalAttack
{
	public class PlayerCollision : MonoBehaviour
	{

		public PlayerMovement movement;     // A reference to our PlayerMovement script

		private Animator anim;

		private void Awake()
		{
			anim = GetComponent<Animator>();
		}

		// This function runs when we hit another object.
		// We get information about the collision and call it "collisionInfo".
		void OnCollisionEnter(Collision collisionInfo)
		{
			// We check if the object we collided with has a tag called "Obstacle".
			if (collisionInfo.collider.tag == "Obstacle")
			{
				anim.SetTrigger("Die");
				movement.enabled = false;   // Disable the players movement.
				FindObjectOfType<GameManager>().EndGame();
			}
		}

	}
}