using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public GameObject gameovertext;
    public Rigidbody2D ball;
    public bool jump;
    public bool stop;
    // Start is called before the first frame update
    void Start()
    {
        jump = true;
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            if (ball.velocity.magnitude < 20f)
            {
                if (Input.GetKey(KeyCode.RightArrow)) ball.AddForce(Vector2.right * 5);
            }
            if (Input.GetKey(KeyCode.LeftArrow)) ball.AddForce(Vector2.left * 5);
            if (Input.GetKeyDown(KeyCode.Space) && jump == true)
            {
                ball.AddForce(Vector2.up * 300);
            }

            //Debug.Log(ball.velocity);
            if (transform.position.x > 5f && ball.velocity.magnitude < 5f)
            {
                stop = true;
                gameovertext.SetActive(true);
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        jump = true;
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        jump = false;
    }
}
