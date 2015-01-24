using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour 
{
	public GameObject enemy;
	public enum FighterState {PUNCH, KICK, JUMP, BLOCK, AIRPUNCH, AIRKICK, NULL};
	public FighterState state = FighterState.NULL;
	public State[] states;
	public Controller control;

	void Update () 
	{
		bool redo = false;

		REDO:
			/*
		switch(state)
		{
			case FighterState.NULL:
				if (Buttons.jump + x < Time.time)
				{
					this.state = FighterState.JUMP;
					redo = true;
				}
				else if (Buttons.punch + x < Time.time) 
				{
					this.state = FighterState.PUNCH;
					redo = true;
				}
				else if (Buttons.kick + x < Time.time) 
				{
					this.state = FighterState.KICK;
					redo = true;
				}
				else if (Buttons.airPunch + x < Time.time) 
				{
					this.state = FighterState.AIRPUNCH;
					redo = true;
				}
				else if (Buttons.airKick + x < Time.time) 
				{
					this.state = FighterState.AIRKICK;
					redo = true;
				}
				else if (Buttons.block + x < Time.time) 
				{
					this.state = FighterState.BLOCK;
					redo = true;
				}
				break;
			case FighterState.PUNCH:
				
				//Punch();
				break;
			case FighterState.KICK:

				//Kick();
				break;
			case FighterState.JUMP:

				//Jump();
				transform.position.y += vy;
				--vy;
				if(transform.position.y <= floor && vy != 15)
				{
					transform.position.y = floor;
					vy = 15;
					state = FighterState.NULL;
				}
				break;
			case FighterState.AIRPUNCH:

				//AirPunch();
				break;
			case FighterState.AIRKICK:

				//AirKick();
				break;
			case FighterState.BLOCK:

				//Block();
				break;
			default:
				Debug.Log ("You Dun Fucked Up");
				break;
		}
	*/
		if(redo) goto REDO;
	}
}
