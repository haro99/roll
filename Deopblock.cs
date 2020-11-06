using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deopblock : MonoBehaviour
{
    public GameObject obj;
    public GameObject drop;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("boll");
        drop = GameObject.Find("Drop");
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.transform.position.x - 7f > transform.position.x)
        {
            drop.GetComponent<Drop>().Cut();
            Destroy(this.gameObject);
        }
    }
}
