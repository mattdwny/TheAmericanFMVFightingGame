using UnityEngine;
using System.Collections;

public class PlayerSelectFramework : MonoBehaviour {

    private string name;
    private float dmgVals;
    private float kbVals;
    private int health;
    private Vector3 startPos;
    private GameObject prefab;


    public PlayerSelectFramework(string in_name, float in_dmgVals, float in_kbVals, int in_health, Vector3 in_startPos, GameObject in_prefab)
    {

        name = in_name;
        dmgVals = in_dmgVals;
        kbVals = in_kbVals;
        health = in_health;
        startPos = in_startPos;
        prefab = in_prefab;

        Instantiate(prefab, startPos, Quaternion.identity);
        DontDestroyOnLoad(transform.gameObject);
    }

	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
