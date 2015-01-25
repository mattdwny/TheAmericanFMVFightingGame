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
				if(player.hitstun_count>0){
					this.state = FighterState.HITSTUN;
					redo = true;
				}else if (LastMoveInput.Value.input == 1 && LastMoveInput.Value.time + x < Time.time)
				{
					this.state = FighterState.JUMP;
					redo = true;
				}
				else if (control.pButtonSt!=0 && !player.isTouchingGround())
				{
					this.state = FighterState.PUNCH;
					redo = true;
				}
				else if (control.kButtonSt !=0&& !player.isTouchingGround()) 
				{
					this.state = FighterState.KICK;
					redo = true;
				}
				else if (control.pButtonSt!=0 && player.isTouchingGround())
				{
					this.state = FighterState.AIRPUNCH;
					redo = true;
				}
				else if (control.kButtonSt!=0&& !player.isTouchingGround()) 
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
				}else if (LastMoveInput.Value.input == 0 && LastMoveInput.Value.time + x < Time.time)
				{
					this.state = FighterState.RIGHT;
					redo = true;
				}else if (LastMoveInput.Value.input == 2 && LastMoveInput.Value.time + x < Time.time)
				{
					this.state = FighterState.LEFT;
					redo = true;
				}else if (LastMoveInput.Value.input == 3 && LastMoveInput.Value.time + x < Time.time)
				{
					this.state = FighterState.CROUCH;
					redo = true;
				}
				break;
			case FighterState.HITSTUN:
				player.hitstun_count--;
				if(player.knockdown == true){
					this.state = FighterState.KNOCKDOWN;
				}
				if(player.hitstun_count<=0){
					player.hitstun_count=0;
					this.state = FighterState.NULL;
				}
				
				break;
			case FighterState.KNOCKDOWN:
				player.hitstun_count=0;
				player.knockdown_count--;
				//enter knockdown handling here
				if(player.knockdown_count<=0){
					player.knockdown_count=0;
					this.state = FighterState.NULL;
				}
				break;
			case FighterState.PUNCH:
				
				player.Attack(0,control.pButtonSt,control.inputStack,player.facing,control.kButtonSt);
				this.state = FighterState.NULL;
				break;
			case FighterState.KICK:
				
				player.Attack(1,control.kButtonSt,control.inputStack,player.facing);
				this.state = FighterState.NULL;
				break;
			case FighterState.JUMP:
				player.Jump();
				this.state = FighterState.NULL;
				break;
			case FighterState.AIRPUNCH:
				
				player.Attack(2,control.pButtonSt,control.inputStack,player.facing,control.kButtonSt);
				this.state = FighterState.NULL;
				break;
			case FighterState.AIRKICK:
				
				player.Attack(3,control.kButtonSt,control.inputStack,player.facing);
				this.state = FighterState.NULL;
				break;
			case FighterState.BLOCK:
				
				player.Block();
				this.state = FighterState.NULL;
				break;
			case FighterState.LEFT:
				
				player.MOVELEFT();
				this.state = FighterState.NULL;
				break;
			case FighterState.RIGHT:
				
				player.MOVERIGHT();
				this.state = FighterState.NULL;
				break;
			default:
				Debug.Log ("You Dun Fucked Up");
				break;
		}
		if(redo) goto REDO;
	}
}
