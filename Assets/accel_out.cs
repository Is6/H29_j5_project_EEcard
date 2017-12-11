using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;


public class accel_out : MonoBehaviour
{

    public static GameObject d;
    public GameObject key;
    //public GameObject br;
    //public GameObject ri;
    //public GameObject le;
   
    //public Button button; //ボタン押し判定用
    private Text g;
    //public ScriptableObject k_s;
    public static string k;
    public string[] another_d = new string[4];//
    private int a = 0;
    public static int b = 0;
    public int c = 1;
    //bool flg = false;
    //private Ray ray;// Rayがヒットしたものの情報 
    //private RaycastHit hit;// RayがヒットしたGameObjectを格納

    // Use this for initialization
    void Start()
    {
        //g = Accel.GetComponent<Text>();//
        //g = GameObject.Find("/Accel/Label").GetComponent<Text>();//

        d = GameObject.Find("Canvas/MainMenu/Window/Accel/Background/Label");//
        g = d.GetComponent<Text>();

        key = GameObject.Find("Canvas/MainMenu/Window");//
        //k_s = key.GetComponent<key_h>();
        //br = GameObject.Find("Canvas/MainMenu/Window/Brake");//
        //le = GameObject.Find("Canvas/MainMenu/Window/Left");//
        //ri = GameObject.Find("Canvas/MainMenu/Window/Right");//
        //button = bu.GetComponent<Button>();

        //b = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //c = br.GetComponent<brake_out>().en();//変更保存
        c = brake_out.en();
        if (c == 0) c = left_out.en();//c = le.GetComponent<left_out>().en();
        if (c == 0) c = right_out.en();//c = ri.GetComponent<right_out>().en();

        if (Input.anyKeyDown && a == 0 && c == 0)
        {
            b = 1;
            k = key.GetComponent<key_h>().key_ju();//キーの入力変更保存

            //another_d[1] = key.GetComponent<config_d>().br_c();
            //another_d[2] = key.GetComponent<config_d>().ri_c();
            //another_d[3] = key.GetComponent<config_d>().le_c();
            another_d[1] = config_d.br_c();
            another_d[2] = config_d.ri_c();
            another_d[3] = config_d.le_c();

            g.text = "Accel : " + k; //ここで変更表示

            if (Input.GetKey(KeyCode.KeypadEnter) && a == 0 && another_d[1] != k && another_d[2] != k && another_d[3] != k)//テンキーのエンター入力で保存
            {
                a = 1;//
               
                b = 0;

               key.GetComponent<config_d>().ac_d();//問題あり　受け渡し　戻り値　設定保存
              
            }
        }
    }

    public static int en() { 
        return b;
    }

    public static string out_a_d(){
        return k;
    }
}
    