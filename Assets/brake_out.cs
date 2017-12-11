using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;


public class brake_out : MonoBehaviour
{

    public GameObject d;
    public GameObject key;
    //public GameObject ac;
    //public GameObject ri;
    //public GameObject le;

    private Text g;

    public static string k;
    public string[] another_d = new string[4];//
    private int a = 0;
    public static int b = 0;
    public int c = 1;

    // Use this for initialization
    void Start()
    {
        d = GameObject.Find("Canvas/MainMenu/Window/Brake/Background/Label");//
        g = d.GetComponent<Text>();

        key = GameObject.Find("Canvas/MainMenu/Window");//   

        //ac = GameObject.Find("Canvas/MainMenu/Window/Accel/Background/Label");//
        //le = GameObject.Find("Canvas/MainMenu/Window/Left");//
        //ri = GameObject.Find("Canvas/MainMenu/Window/Right");//

        //b = 1;
    }

    // Update is called once per frame
    void Update()
    {
        c = accel_out.en();//変更保存
        if (c == 0) c = left_out.en();
        if (c == 0) c = right_out.en();

        if (Input.anyKeyDown && a == 0 && c == 0)
        {
            b = 1;
            k = key.GetComponent<key_h>().key_ju();//キーの入力変更保存
            
            another_d[0] = config_d.ac_c();
            another_d[2] = config_d.ri_c();
            another_d[3] = config_d.le_c();

            g.text = "Brake : " + k; //ここで変更表示

            if (Input.GetKey(KeyCode.KeypadEnter) && a == 0 && another_d[0] != k && another_d[2] != k && another_d[3] != k)//テンキーのエンター入力で保存
            {
                a = 1;//
               
                b = 0;
                key.GetComponent<config_d>().br_d();//設定保存
            }
        }
    }
    public static int en()
    {
        return b;
    }

    public static string out_b_d()
    {
        return k;
    }
}