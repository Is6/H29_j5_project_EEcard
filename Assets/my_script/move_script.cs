using UnityEngine;
using System.Collections;

public class move_script : MonoBehaviour
{

    float speed;
    float ang;
    public Vector3 center;
    private Rigidbody rb;//

    //追加部分　コンフィグで変更したキー情報を格納
    public static string[] c_data = new string[4] { null, null, null, null };

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = center;

        //追加部分 config_dからキー情報を取得し格納
        c_data[0] = config_d.ac_c();//
        c_data[1] = config_d.br_c();//
        c_data[2] = config_d.ri_c();//
        c_data[3] = config_d.le_c();//

        //追加部分 キー情報に変更が無ければ元の値を入力する
        if (c_data[0] == null) c_data[0] = "w";//
        if (c_data[1] == null) c_data[1] = "space";//
        if (c_data[2] == null) c_data[2] = "d";//
        if (c_data[3] == null) c_data[3] = "a";//

        //エラー処理
        if (c_data[0] == c_data[1] || c_data[0] == c_data[2] || c_data[0] == c_data[3]) c_data[0] = "w";//
        if (c_data[0] == c_data[1] || c_data[1] == c_data[2] || c_data[1] == c_data[3]) c_data[1] = "space";//
        if (c_data[0] == c_data[2] || c_data[1] == c_data[2] || c_data[2] == c_data[3]) c_data[2] = "d";//
        if (c_data[0] == c_data[3] || c_data[3] == c_data[2] || c_data[1] == c_data[3]) c_data[3] = "a";//
    }

    // Update is called once per frame
    void Update()
    {

        KeyAction();

        //Debug.Log("speed" + speed);

        if (speed > 115f)
        {
            speed = 115f;
        }

        if (speed > 0)
        {
            speed--;
        }
        if (speed < 0)
        {
            speed = 0;
        }
        transform.Rotate(0, ang, 0);
        ang = 0;

        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision coli)
    {
        if (coli.gameObject.CompareTag("Wall"))
        {
            Debug.Log("wall collision");
            Debug.Log("Collision speed" + speed);
        }
    }

    void OnCollisionStay(Collision coli)
    {
        if (coli.gameObject.CompareTag("Wall"))
        {
            // Debug.Log("wall collision");
            // Debug.Log("Collision speed" + speed);
            speed = 0;
        }
    }

    void KeyAction()
    {
        
        if (Input.GetKey(c_data[0])) //追加部分 キーの変更
        {
            speed += 2f;
        }

        if (Input.GetKey(c_data[1])) //追加部分 キーの変更
        {
            speed -= 2f;
        }

        if (Input.GetKey(c_data[3])) //追加部分 キーの変更
        {
            ang -= 2f;
        }
        if (Input.GetKey(c_data[2])) //追加部分 キーの変更
        {
            ang += 2f;
        }
    }
}
