using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour 
{	
	public MovementController player;
	public MovementController enemy;
	HitBox hit;
	public int hitstun;

	void OnCollisionEnter2D(Collision c)
	{
		if(enemy== c.contacts[0].otherCollider.gameObject.GetComponentInChildren<MovementController>())
		{
			enemy.health -= hit.damage.Evaluate(hit.time);
			enemy.velX += hit.knb_x * player.facing;
			enemy.velY += hit.knb_y;
			enemy.hitstun_count += hitstun;
			Destroy(this.gameObject);
		}
	}
	void SpecialMove()
	{

	}
	void HyperCombo()
	{

	}
}
