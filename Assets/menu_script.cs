using UnityEngine;
using System.Collections;

public class menu_script : MonoBehaviour {

	// Use this for initialization
	void OnGUI()
    {
        GUI.Button(new Rect(10, 10, 100, 90), "Text");
    }
}