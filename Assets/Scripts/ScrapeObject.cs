using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScrapeObject : MonoBehaviour
{
    bool updated;
    public GameObject watchObjectUp;
    public GameObject watchObjectLeft;
    public GameObject watchObjectDown;
    public GameObject watchObjectRight;
    // Start is called before the first frame update
    void Start()
    {
        updated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (updated) return;
        try
        {
            GameObject obj = transform.GetChild(0).GetChild(0).gameObject;
            Debug.Log("Watch on Top");
            GameObject watchUp = Instantiate(obj,watchObjectUp.transform);
            watchUp.transform.position = new Vector3(0f, 0f, 0f);
            watchUp.transform.rotation = Quaternion.Euler(0, 0, 0);
            Debug.Log("Watch on Left");
            GameObject watchLeft = Instantiate(obj, watchObjectLeft.transform);
            watchLeft.transform.position = new Vector3(1.58f*15, -2.72f*15, 0f);
            watchLeft.transform.rotation = Quaternion.Euler(0, 0, -90);
            Debug.Log("Watch on Bottom");
            GameObject watchDown = Instantiate(obj, watchObjectDown.transform);
            watchDown.transform.position = new Vector3(0f, -4.89f * 15, 0f);
            watchDown.transform.rotation = Quaternion.Euler(0, 0, -180);
            Debug.Log("Watch on Right");
            GameObject watchRight = Instantiate(obj, watchObjectRight.transform);
            watchRight.transform.position = new Vector3(-2.44f * 15, -3.44f * 15, 0f);
            watchRight.transform.rotation = Quaternion.Euler(0, 0, -270);
            updated = true;
        } catch (Exception e)
        {
            Debug.Log(e);
        }
    }
}
