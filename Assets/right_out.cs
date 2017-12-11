using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.UI;

public class right_out : MonoBehaviour {

    public GameObject d;
    public GameObject key;
    //public GameObject ac;
    //public GameObject le;
    //public GameObject br;

    private Text g;

    public static string k;
    public string[] another_d = new string[4];//
    private int a = 0;
    public static int b = 0;
    public int c = 1;

    // Use this for initialization
    void Start () {
        d = GameObject.Find("Canvas/MainMenu/Window/Right/Background/Label");//
        g = d.GetComponent<Text>();

        key = GameObject.Find("Canvas/MainMenu/Window");//

        //br = GameObject.Find("Canvas/MainMenu/Window/Brake");//
        //ac = GameObject.Find("Canvas/MainMenu/Window/Accel/Background/Label");//Labelの奥にあるから
        //le = GameObject.Find("Canvas/MainMenu/Window/Left");//

        //b = 1;
    }
	
	// Update is called once per frame
	void Update () {
        c = accel_out.en();//変更保存
        if (c == 0) c = brake_out.en();
        if (c == 0) c = left_out.en();

        if (Input.anyKeyDown && a == 0 && c == 0)
        {
            b = 1;
            k = key.GetComponent<key_h>().key_ju();//キーの入力変更保存
            
            another_d[0] = config_d.ac_c();
            another_d[1] = config_d.br_c();
            another_d[3] = config_d.le_c();

            g.text = "Right : " + k; //ここで変更表示

            if (Input.GetKey(KeyCode.KeypadEnter) && a == 0 && another_d[0] != k && another_d[1] != k && another_d[3] != k)//テンキーのエンター入力で保存
            {
                a = 1;//
                
                b = 0;
                key.GetComponent<config_d>().ri_d();//設定保存
            }
        }
    }

    public static int en()
    {
        return b;
    }

    public static string out_r_d()
    {
        return k;
    }
}
