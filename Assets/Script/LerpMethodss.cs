using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMethodss : MonoBehaviour
{
    public GameObject targetObj;
    public float x = 1;

    //for translate from lerp method
    public Vector3 startPos = new Vector3(-1.9f, 0.48f, 5.89f);
    public Vector3 endPos = new Vector3(17.2f, 0.48f, 5.89f);
    public float timeCover;
    public float duration = 0.6f;

    void Awake()
    {
        //Intentiate object(prefab) in runtime
        // Invoke("showLately", 3);

        //Existing object true/false and show in delay.
        /*targetObj.SetActive(false);
        Debug.Log("Awake call");
        if(targetObj.active == false)
        {
            Invoke("showLately", 3);
        }*/
    }

    void Start()
    {
        Debug.Log("start call");
        //just one obj render delay in given time 
        // Invoke("unlimetedRenderObject", 3);

        //multiple object render in delay after that every 2sec multiple object render
        InvokeRepeating("unlimetedRenderObject", 4, 2);
    }

    void Update()
    {
        Debug.Log("update call");
        //delay run for translate
        // InvokeRepeating("translatePos", 4, 2);

        //dirct run for translate
        // translatePos();
    }

    void translatePos()
    {
        //here time is your...
        timeCover += Time.deltaTime;
        float percentageComplete = timeCover / duration;
        targetObj.transform.position = Vector3.Lerp(startPos, endPos, percentageComplete);
    }

    void unlimetedRenderObject()
    {
        Instantiate(targetObj, new Vector3(x * 2, 0.48f, 5.89f),Quaternion.identity);
        x++;
    }

    void showLately()
    {
        //object show in delay and clone prefab in runtime
        Instantiate(targetObj);
        //direct object render and set true/false
        // targetObj.SetActive(true);
    }
}
