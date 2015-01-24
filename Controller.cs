using UnityEngine;
using System.Collections;

public class Controller {
	enum Inputs {B_PUNCH, B_KICK,POS_A_HORIZONTAL, POS_A_VERTICAL,NEG_A_HORIZONTAL, NEG_A_VERTICAL};
	public LinkedList<inputHolder> inputStack;
	public float decayTime;
	public string p,k,h,v;
	public Controller(string punchButton,string kickButton,string horAxis,string verAxis){
		p=punchButton;
		k=kickButton;
		h=horAxis;
		v=verAxis;
	}
	
	
	// Update is called once per frame
	void UpdateInput ()
	{
		LinkedListNode<inputHolder> CheckedInput = inputStack.first;
		while(CheckedInput != null)
		{
			if(Time.time - CheckInput.Value.time > decayTime)
			{
				inputHolder Temp = CheckedInput;
				CheckedInput = CheckedInput.next;
				inputStack.remove(Temp);
				
			}
			else
			{
				CheckedInput = CheckedInput.next;
			}
		}
		if(Input.GetKeyPress(p)){
			inputStack.AddLast(new inputHolder(B_punch));
		}
		if(Input.GetKeyPress(k)){
			inputStack.AddLast(new inputHolder(B_KICK));
		}
		if(Input.GetAxis(horAxis)>0){
			inputStack.AddLast(new inputHolder(POS_A_HORIZONTAL));
		}
		if(Input.GetAxis(horAxis)<0){
			inputStack.AddLast(new inputHolder(NEG_A_HORIZONTAL));
		}
		if(Input.GetAxis(verAxis)>0){
			inputStack.AddLast(new inputHolder(POS_A_VERTICAL));
		}
		if(Input.GetAxis(verAxis)<0){
			inputStack.AddLast(new inputHolder(NEG_A_VERTICAL));
		}
	}
}
