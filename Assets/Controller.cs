using UnityEngine;
using System.Collections.Generic;

/*
public class Controller : MonoBehaviour
{
	enum Inputs {POS_A_HORIZONTAL, POS_A_VERTICAL,
		NEG_A_HORIZONTAL, NEG_A_VERTICAL, NULL_A_VERTICAL, NULL_A_HORIZONTAL};
	public int pButtonSt,kButtonSt;
	public LinkedList<inputHolder> inputStack;
	public float decayTime;
	public KeyCode p,k;
	public String h,v;
	public Controller(KeyCode punchButton,KeyCode kickButton,string horAxis,string verAxis)
	{
		p=punchButton;
		k=kickButton;
		h=horAxis;
		v=verAxis;
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		LinkedListNode<inputHolder> CheckedInput = inputStack.First;
		while(CheckedInput != null)
		{
			if(Time.time - CheckedInput.Value.time > decayTime)
			{
				inputHolder Temp = CheckedInput.Value;
				CheckedInput = CheckedInput.Next;
				inputStack.Remove(Temp);
				
			}
			else
			{
				CheckedInput = CheckedInput.Next;
			}
		}
		pButtonSt =0;
		kButtonSt = 0;
		if(Input.GetButtonDown(p)){
			pButtonSt = 1;
		}
		if(Input.GetButtonDown(k)){
			kButtonSt = 1;
		}
		if(Input.GetButtonUp(p)){
			pButtonSt = -1;
			
		}
		if(Input.GetButtonUp(k)){
			kButtonSt = -1;
		}
		if(Input.GetAxis(h)>0)
			inputStack.AddLast(new inputHolder((int) Inputs.POS_A_HORIZONTAL));
		else if(Input.GetAxis(h)<0) 
			inputStack.AddLast(new inputHolder((int) Inputs.NEG_A_HORIZONTAL));
		else if(Input.GetAxis(h)==0)
			inputStack.AddLast(new inputHolder((int) Inputs.NULL_A_HORIZONTAL));

		if(Input.GetAxis(v)>0)
			inputStack.AddLast(new inputHolder((int) Inputs.POS_A_VERTICAL));
		else if(Input.GetAxis(v)<0)
			inputStack.AddLast(new inputHolder((int) Inputs.NEG_A_VERTICAL));
		else if(Input.GetAxis(v)==0)
			inputStack.AddLast(new inputHolder((int) Inputs.NULL_A_VERTICAL));

	}
  
}

*/