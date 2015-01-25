using UnityEngine;
using System.Collections;
public class SoundPlayer : MonoBehaviour
{
	Random random = new Random();
	public AudioClip[] baby;
	public AudioClip[] zakGrunt;
	public AudioClip[] zakDmg;
	public AudioClip[] johnDmg;
	public AudioClip[] johnGrunt;
	public AudioClip falconPunch;
	public AudioClip world;
	public AudioClip splashScreen;
	public AudioClip johnTaunt;
	public AudioClip johnJump;
	public AudioSource source;

	void Start()
	{
		AudioClip[] baby = new AudioClip[4];
		baby [0] = Resources.Load ("BABY_1") as AudioClip;
		baby [1] = Resources.Load ("BABY_2") as AudioClip;
		baby [2] = Resources.Load ("BABY_3") as AudioClip;
		baby [3] = Resources.Load ("BABY_4") as AudioClip;
		AudioClip[] zakGrunt = new AudioClip[4];
		zakGrunt[0] = Resources.Load("Zak_Grunt_1") as AudioClip;
		zakGrunt[1] = Resources.Load("Zak_Grunt_2") as AudioClip;
		zakGrunt[2] = Resources.Load("Zak_Grunt_3") as AudioClip;
		zakGrunt[3] = Resources.Load("Zak_Grunt_4") as AudioClip;
		AudioClip[] zakDmg = new AudioClip[3];
		zakDmg[0] = Resources.Load("Zak_Grunt_Dmg_1") as AudioClip;
		zakDmg[1] = Resources.Load("Zak_Grunt_Dmg_2") as AudioClip;
		zakDmg[2] = Resources.Load("Zak_Grunt_Dmg_3") as AudioClip;
		AudioClip[] johnDmg = new AudioClip[2];
		johnDmg[0] = Resources.Load ("John_Dmg_1") as AudioClip;
		johnDmg[1] = Resources.Load ("John_Dmg_2") as AudioClip;
		AudioClip[] johnGrunt = new AudioClip[4];
		johnGrunt [0] = Resources.Load ("John_Grunt_1") as AudioClip;
		johnGrunt [1] = Resources.Load ("John_Grunt_2") as AudioClip;
		johnGrunt [2] = Resources.Load ("John_Grunt_3") as AudioClip;
		johnGrunt [3] = Resources.Load ("John_Grunt_4") as AudioClip;
		splashScreen = Resources.Load ("LOGO SPLASH SOUND_1") as AudioClip;
		falconPunch = Resources.Load ("FALCON PUNCH-U_1") as AudioClip;
		johnJump = Resources.Load ("John_Jump_1") as AudioClip;
		johnTaunt = Resources.Load ("JAP JOHN_1") as AudioClip;
		world = Resources.Load ("IN A WORLD_1") as AudioClip;
		source = gameObject.AddComponent<AudioSource> ();
		source.PlayOneShot(splashScreen);
	}
	public void playBaby()
	{
		source.PlayOneShot(baby[random.Next(0, 4)]);
	}
	public void playZakGrunt()
	{
		source.PlayOneShot(zakGrunt[random.Next(0, 4)]);
	}

	public void playZakDmg()
	{
		source.PlayOneShot(zakDmg[random.Next(0, 3)]);
	}

	public void playJohnDmg()
	{
		source.PlayOneShot(johnDmg[random.Next(0, 2)]);
	}

	public void playJohnGrunt()
	{
		source.PlayOneShot(johnGrunt[random.Next(0, 4)]);
	}
	public void playFalconPunch()
	{
		source.PlayOneShot(falconPunch);
	}
	public void playWorld()
	{
		source.PlayOneShot(world);
	}
	public void playSplashScreen()
	{
		source.PlayOneShot(splashScreen);
	}
	public void playJohnTaunt()
	{
		source.PlayOneShot(johnTaunt);
	}

	public void playJohnJump()
	{
		source.PlayOneShot(johnJump);
	}

	public void playJohnTaunt()
	{
		source.PlayOneShot(johnTaunt);
	}
	void Update()
	{
	}
}

