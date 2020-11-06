using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    //Ballオブジェクト
    public GameObject boll;
    //速度の変数
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //リジットからXの速度だけとってくる
        speed = boll.GetComponent<Rigidbody2D>().velocity.x;
        //textに速度を表示する
        GetComponent<Text>().text = (int)speed + "k/m";
    }
}
