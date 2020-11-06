using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject boll;
    public GameObject[] ob;
    public Vector3 position;
    public int drop;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position - boll.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = boll.transform.position + position;

        int number = Random.Range(1, 6);

        if (number == 1)
        {
            if (drop < 3) 
            {
                GameObject.Instantiate(ob[Random.Range(0, 3)], transform.position, transform.rotation);
                drop++;
            }

        }
    }

    public void Cut() 
    {
        drop--;
    }
}
