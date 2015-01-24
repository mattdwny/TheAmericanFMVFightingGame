using UnityEngine;
using System.Collections;

public class PlyrSelect : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public static bool playerOne;
    public static bool loadLevel;

    void OnGUI()
    {
        Object obj = null;
        playerOne = true;
        loadLevel = false;
        if (!loadLevel)
        {
            if (GUI.Button(new Rect(100, 100, 200, 200), "This is the first character"))
            {
                obj = Instantiate(prefab1, new Vector3((playerOne ? 0 : 400), 200, 0), Quaternion.identity);
            }
            else if (GUI.Button(new Rect(100, 400, 200, 200), "This is the second character"))
            {
                obj = Instantiate(prefab2, new Vector3((playerOne ? 0 : 400), 200, 0), Quaternion.identity);
            }
            else if (GUI.Button(new Rect(400, 100, 200, 200), "This is the third character"))
            {
                obj = Instantiate(prefab3, new Vector3((playerOne ? 0 : 400), 200, 0), Quaternion.identity);
            }
            else if (GUI.Button(new Rect(400, 400, 200, 200), "This is the fourth character"))
            {
                obj = Instantiate(prefab4, new Vector3((playerOne ? 0 : 400), 200, 0), Quaternion.identity);
            }
            DontDestroyOnLoad(obj);
            if (!playerOne) loadLevel = true;
        }
        if (GUI.Button(new Rect(100, 100, 200, 200), "This is the ice level"))
        {
            Application.LoadLevel("Ice Level");
        }
        else if (GUI.Button(new Rect(100, 100, 200, 200), "This is not the ice level"))
        {
            Application.LoadLevel("Elevator Level");
        }
    }
}
