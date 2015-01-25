using UnityEngine;
using System.Collections;

[System.Serializable]

public class HitBox
{
	public AnimationCurve damage;
	public AnimationCurve pos_x , pos_y;
	public AnimationCurve size_x, size_y;
	public float knb_x;
	public float knb_y;
}
