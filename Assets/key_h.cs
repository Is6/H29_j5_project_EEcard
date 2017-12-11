using UnityEngine;
using System.Collections;

public class key_h : MonoBehaviour
{

    public string k = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string key_ju() {

        //k = null;

        if (Input.anyKeyDown)
        {
            /*
            if (Input.GetKey(KeyCode.A)) { k = "A"; }
            if (Input.GetKey(KeyCode.B)) { k = "B"; }
            if (Input.GetKey(KeyCode.C)) { k = "C"; }
            if (Input.GetKey(KeyCode.D)) { k = "D"; }
            if (Input.GetKey(KeyCode.E)) { k = "E"; }
            if (Input.GetKey(KeyCode.F)) { k = "F"; }
            if (Input.GetKey(KeyCode.G)) { k = "G"; }
            if (Input.GetKey(KeyCode.H)) { k = "H"; }
            if (Input.GetKey(KeyCode.I)) { k = "I"; }
            if (Input.GetKey(KeyCode.J)) { k = "J"; }
            if (Input.GetKey(KeyCode.K)) { k = "K"; }
            if (Input.GetKey(KeyCode.L)) { k = "L"; }
            if (Input.GetKey(KeyCode.M)) { k = "M"; }
            if (Input.GetKey(KeyCode.N)) { k = "N"; }
            if (Input.GetKey(KeyCode.O)) { k = "O"; }
            if (Input.GetKey(KeyCode.P)) { k = "P"; }
            if (Input.GetKey(KeyCode.Q)) { k = "Q"; }
            if (Input.GetKey(KeyCode.R)) { k = "R"; }
            if (Input.GetKey(KeyCode.S)) { k = "S"; }
            if (Input.GetKey(KeyCode.T)) { k = "T"; }
            if (Input.GetKey(KeyCode.U)) { k = "U"; }
            if (Input.GetKey(KeyCode.V)) { k = "V"; }
            if (Input.GetKey(KeyCode.W)) { k = "W"; }
            if (Input.GetKey(KeyCode.X)) { k = "X"; }
            if (Input.GetKey(KeyCode.Y)) { k = "Y"; }
            if (Input.GetKey(KeyCode.Z)) { k = "Z"; }*/

            if (Input.GetKey(KeyCode.A)) { k = "a"; }
            if (Input.GetKey(KeyCode.B)) { k = "b"; }
            if (Input.GetKey(KeyCode.C)) { k = "c"; }
            if (Input.GetKey(KeyCode.D)) { k = "d"; }
            if (Input.GetKey(KeyCode.E)) { k = "e"; }
            if (Input.GetKey(KeyCode.F)) { k = "f"; }
            if (Input.GetKey(KeyCode.G)) { k = "g"; }
            if (Input.GetKey(KeyCode.H)) { k = "h"; }
            if (Input.GetKey(KeyCode.I)) { k = "i"; }
            if (Input.GetKey(KeyCode.J)) { k = "j"; }
            if (Input.GetKey(KeyCode.K)) { k = "k"; }
            if (Input.GetKey(KeyCode.L)) { k = "l"; }
            if (Input.GetKey(KeyCode.M)) { k = "m"; }
            if (Input.GetKey(KeyCode.N)) { k = "n"; }
            if (Input.GetKey(KeyCode.O)) { k = "o"; }
            if (Input.GetKey(KeyCode.P)) { k = "p"; }
            if (Input.GetKey(KeyCode.Q)) { k = "q"; }
            if (Input.GetKey(KeyCode.R)) { k = "r"; }
            if (Input.GetKey(KeyCode.S)) { k = "s"; }
            if (Input.GetKey(KeyCode.T)) { k = "t"; }
            if (Input.GetKey(KeyCode.U)) { k = "u"; }
            if (Input.GetKey(KeyCode.V)) { k = "v"; }
            if (Input.GetKey(KeyCode.W)) { k = "w"; }
            if (Input.GetKey(KeyCode.X)) { k = "x"; }
            if (Input.GetKey(KeyCode.Y)) { k = "y"; }
            if (Input.GetKey(KeyCode.Z)) { k = "z"; }

            if (Input.GetKey(KeyCode.UpArrow)) { k = "up"; }
            if (Input.GetKey(KeyCode.DownArrow)) { k = "down"; }
            if (Input.GetKey(KeyCode.RightArrow)) { k = "right"; }
            if (Input.GetKey(KeyCode.LeftArrow)) { k = "left"; }

            if (Input.GetKey(KeyCode.Space)) { k = "space"; }
        }
        return k;
    }
}