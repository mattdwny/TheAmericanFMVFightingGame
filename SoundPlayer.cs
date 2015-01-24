using UnityEngine;
using System.Collections;
public class SoundPlayer : MonoBehaviour
{
	public AudioClip punchSound;
	public AudioClip kickSound;
	public AudioClip jumpSound;
	public AudioClip hitSound;
	public AudioClip deathSound;
	public AudioClip song1;
	public AudioSource source;
	void Start()
	{
		//source = GetComponent<AudioSource> ();
		source = gameObject.AddComponent<AudioSource> ();
		source.PlayOneShot(punchSound);

	}

	void Update()
	{
		Debug.Log ("music played");
	}
}

