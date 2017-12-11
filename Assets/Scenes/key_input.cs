using UnityEngine;
using System.Collections;

public class key_input : MonoBehaviour {

    private string text = "";
    void OnGUI()
    {
        Rect rect1 = new Rect(10, 10, 40, 30);
        text = GUI.TextField(rect1, text, 16);
    }

}
