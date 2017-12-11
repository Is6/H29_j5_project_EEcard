using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;

public class config_d : MonoBehaviour {

    //public GameObject d;
    //public GameObject key;
    //public GameObject ac;
    //public GameObject br;
    //public GameObject ri;
    //public GameObject le;

    private string k;

    public static string[] data = new string[4] {null,null,null,null};//
    public int[] check = new int[4];

    // Use this for initialization
    void Start () {

        //ac = GameObject.Find("Canvas/MainMenu/Window/Accel/Background/Label");//
        //br = GameObject.Find("Canvas/MainMenu/Window/Brake");//
        //le = GameObject.Find("Canvas/MainMenu/Window/Left");//
        //ri = GameObject.Find("Canvas/MainMenu/Window/Right");//
        //k = key.GetComponent<key_h>().key_ju();//キーの入力変更保存
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ac_d()
    {
        //data[0] = ac.GetComponent<accel_out>().out_a_d();
        data[0] = accel_out.out_a_d();//
        check[0] = 1;
    }

    public void br_d()
    {
        //data[1] = br.GetComponent<brake_out>().out_b_d();
        data[1] = brake_out.out_b_d();
        check[1] = 1;
    }

    public void ri_d()
    {
        //data[2] = ri.GetComponent<right_out>().out_r_d();
        data[2] = right_out.out_r_d();
        check[2] = 1;
    }

    public void le_d()
    {
        //data[3] = le.GetComponent<left_out>().out_l_d();
        data[3] = left_out.out_l_d();
        check[3] = 1;
    }

    public static string ac_c()
    {
        return data[0];
    }

    public static string br_c()
    {
        return data[1];
    }

    public static string ri_c()
    {
        return data[2];
    }

    public static string le_c()
    {
        return data[3];
    }
}
