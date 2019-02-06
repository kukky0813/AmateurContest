using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class MainCamera : MonoBehaviour {
    //-----------------------------------------------
    //変数
    //-----------------------------------------------
    public GameObject target;
    private float F_rotateY = 0;
    private const int MOUSESENSITIVITY = 1;

    //-----------------------------------------------
    //関数
    //-----------------------------------------------
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float F_mouseMove = Input.GetAxis("Mouse X");
        if (F_mouseMove > 0)
        {
            F_rotateY += 1f;
        }
        if (F_mouseMove < 0)
        {
            F_rotateY -= 1f;
        }


        this.transform.position = target.transform.position;
        this.transform.rotation = Quaternion.Euler(15, F_rotateY * 5, 0);
        this.transform.Translate(new Vector3(0, 1f, -2.5f));
    }
}
