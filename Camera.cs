using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject ball;

    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        //カメラとボールの距離の感覚を確保
        position = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = new Vector3(ball.transform.position.x + position.x, transform.position.y, position.z);

    }
}
