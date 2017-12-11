using UnityEngine;
using System.Collections;

public class TestTextField: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private string text = "";
    void OnGUI()
    {
        Rect rect1 = new Rect(10, 10, 20, 30);
        text = GUI.TextField(rect1, text, 1);
    }

}
