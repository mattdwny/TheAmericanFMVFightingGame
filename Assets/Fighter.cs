using UnityEngine;
using System.Collections.Generic;

[System.Serializable]

public class Fighter : MonoBehaviour 
{
	public GameObject enemy;
	public enum FighterState {PUNCH, KICK, JUMP, BLOCK, AIRPUNCH, AIRKICK, NULL};
	public FighterState state = FighterState.NULL;
	public State[] states;
	public Controller control;
	public MovementController player;
	void Update () 
	{
		bool redo = false;

		REDO:
		switch(state)
		{
			case FighterState.NULL:
				LinkedListNode<inputHolder> LastMoveInput = control.inputStack.Last;
			
				if (LastMoveInput.Value.input == 1 && LastMoveInput.Value.time + x < Time.time)
				{
					this.state = FighterState.JUMP;
					redo = true;
				}
				else if (control.pButtonSt==1 && !player.isTouchingGround())
				{
					this.state = FighterState.PUNCH;
					redo = true;
				}
				else if (control.kButtonSt==1&& !player.isTouchingGround()) 
				{
					this.state = FighterState.KICK;
					redo = true;
				}
				else if (control.pButtonSt==1 && player.isTouchingGround())
				{
					this.state = FighterState.AIRPUNCH;
					redo = true;
				}
				else if (control.kButtonSt==1&& !player.isTouchingGround()) 
				{
					this.state = FighterState.AIRKICK;
					redo = true;
				}
				else if (player.facing = 1 && LastMoveInput.Value.input == 0 && LastMoveInput.Value.time + x < Time.time) 
				{
					this.state = FighterState.BLOCK;
					redo = true;
				}else if (player.facing = 0 && LastMoveInput.Value.input == 2 && LastMoveInput.Value.time + x < Time.time) 
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
		if(redo) goto REDO;
	}
}
