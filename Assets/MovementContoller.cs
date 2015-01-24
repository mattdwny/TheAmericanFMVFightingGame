using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{
	public float health = 100;
	public float current_x;
	public float current_y;
	public int facing = 1;
	public float moveSpeed = 6f;
	public float jumpSpeed = 20f;
	private bool grounded = false;
	private const int MAX_JUMPS = 2;
	public int hitstun_count;

	private int jumpsRemaining;
	public float velX;
	public float velY;
	private float grav = 40f;
	private const float MAX_JUMP_HEIGHT = 60;
	private bool jumping;
	// Use this for initialization
	void Start () 
	{
		jumpsRemaining = MAX_JUMPS;
		grounded = false;
		transform.rigidbody2D.isKinematic = true;
		velX = 0f;
		velY = 0f;
		jumping = false;
		current_x = transform.position.x;
		current_y = transform.position.y;
		hitstun_count = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		BoundaryCheck();
	}
	
	void Move()
	{	
		if (!grounded) velY -= grav/2 * Time.deltaTime;
		
		if(grounded) 
		{
			transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed, velY, 0f) * Time.deltaTime;
		}
		else
		{
			//Directional Influence
		}
		
		if (!grounded) velY -= grav/2 * Time.deltaTime;
	}
	void Jump()
	{
		if (jumpsRemaining > 0)
		{
			if (grounded) grounded = false;
			jumping = true;
			
			Debug.Log("in jump");
			
			jumpsRemaining--;

			velY = jumpSpeed;
		}
	}
	
	void BoundaryCheck()
	{	
		if (transform.position.x < -10f && velX <= 0f)
		{
			transform.position = new Vector3( -10f, transform.position.y, 0f);
		}
		else if (transform.position.x > 10f && velX >= 0f)
		{
			transform.position = new Vector3(  10f, transform.position.y, 0f);
		}
		
		if (transform.position.y <= 0 && velY < 0f)
		{
			velY = 0;
			transform.position = new Vector3(transform.position.x, 0f, 0f);
			jumpsRemaining = MAX_JUMPS;
			grounded = true;
		}
	}
	void Punch(int curstate,LinkedList<inputHolder> inputs, int dir,int super){
		LinkedListNode<inputHolder> Inputs = control.inputStack.Last;
		switch(Inputs.value.input){
			
		}
	
	}
	
	void AirPunch(int curstate,LinkedList<inputHolder> inputs, int dir, int super){
		
	}
	
	void Kick(int curstate,LinkedList<inputHolder> inputs, int dir){
		
	}
	
	void AirKick(int curstate,LinkedList<inputHolder> inputs, int dir){
		
	}
}

