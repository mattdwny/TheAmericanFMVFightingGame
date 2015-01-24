using UnityEngine;
using System.Collections;

public class Controller {
	enum Inputs {B_PUNCH, B_KICK,POS_A_HORIZONTAL, POS_A_VERTICAL,NEG_A_HORIZONTAL, NEG_A_VERTICAL};
	public LinkedList<inputHolder> inputStack;
	public float decayTime;
	void configure(){
	
	}
	
	
	// Update is called once per frame
	void UpdateInput () {
		LinkedListNode<inputHolder> CheckedInput = inputStack.first;
		while(CheckedInput != null){
			if(Time.time-CheckInput.Value.time> decayTime){
				inputHolder Temp = CheckedInput;
				CheckedInput = CheckedInput.next;
				inputStack.remove(Temp);
				
			}else{
				CheckedInput = CheckedInput.next;
			}
		}
	}
}
