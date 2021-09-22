using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    public Transform targetObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        commonMethodLookat();
    }

    void commonMethodLookat()
    {
        transform.LookAt(targetObject);
        //transform.LookAt(targetObject, Vector3.left);
    }
}
