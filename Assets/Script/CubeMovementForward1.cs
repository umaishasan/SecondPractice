using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementForward1 : MonoBehaviour
{
    public Animator anim;
    [SerializeField] private Camera mainCamera;
    public GameObject g;
    public float myspeedScript;

    // Update is called once per frame
    void Update()
    {
        //float startT = Time.time;
        
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hiting;
        bool boolPhy = Physics.Raycast(ray, out hiting);
        if (Input.GetMouseButtonDown(0))
        {
           // hiting.collider.gameObject.GetComponent<Renderer>().material.color = 
            g.transform.localRotation = hiting.transform.localRotation;
            myspeedScript = 1.03f;
            if (myspeedScript > 1)
            {
                anim.SetFloat("Speed", myspeedScript);
                anim.Play("Walk");
                if (boolPhy)
                {

                  g.transform.position = Vector3.Lerp(g.transform.position, hiting.point,5*Time.deltaTime) ;
                }
                //transform.Translate(new Vector3(0, 0, 4f * myspeedScript) * Time.deltaTime);
            }
            //transform.Translate(new Vector3(0, 0, 4f * myspeedScript) * Time.deltaTime);
            // transform.position = gameObject.transform.position;
            Debug.Log("Mouse click call");
        }

        // move();
    }

    //FROM MOUSE
/*    void OnMouseDown()
    {
        transform.position = g.transform.position;
        Debug.Log("Mouse click call");
        Debug.Log(g);
    }*/

    //FROM KEYBOARD
    /*void move()
    {
        //movement for key down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myspeedScript = 1.03f;
            if (myspeedScript>1)
            {
                anim.SetFloat("Speed", myspeedScript);
                anim.Play("Walk");
                Debug.Log("UpWalk");
                transform.Translate(new Vector3(0, 0, 4f*myspeedScript)*Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myspeedScript = 1.03f;
            if (myspeedScript>1)
            {
                anim.SetFloat("Speed", myspeedScript);
                anim.Play("Walk");
                Debug.Log("DownWalk");
                transform.Translate(new Vector3(0, 0, -4f*myspeedScript) * Time.deltaTime);
            }
        }

        //pickup for key down
        if (Input.GetKey(KeyCode.P))
        {
            myspeedScript = 1f;
            if (myspeedScript >= 1)
            {
                anim.SetFloat("Speed", myspeedScript);
                anim.Play("PickUp");
                *//*Debug.Log("DownWalk");
                transform.Translate(new Vector3(0, 0, -4f * speed) * Time.deltaTime);*//*
            }
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            myspeedScript = 0f;
            if (myspeedScript <= 0)
            {
                anim.SetFloat("Speed", myspeedScript);
                anim.Play("Idle");
                Debug.Log("DownWalk");
                transform.Translate(new Vector3(0, 0, -4f * myspeedScript) * Time.deltaTime);
            }
        }

        //running for key down
        if (Input.GetKey(KeyCode.R))
        {
            myspeedScript = 5.03f;
            if (myspeedScript > 1)
            {
                anim.SetFloat("Speed", myspeedScript);
                anim.Play("Run");
                Debug.Log("R");
                transform.Translate(new Vector3(0, 0, 4f * myspeedScript) * Time.deltaTime);
            }
        }*/

    /*if (Input.GetKey(KeyCode.R))
    {
        speed = 1.03f;
        if (speed > 1)
        {
            anim.SetFloat("Speed", speed);
            anim.Play("Run");
            Debug.Log("R");
            transform.Translate(new Vector3(0, 0, -4f * speed) * Time.deltaTime);
        }
    }*/

    //stand for key release
    /*if (Input.GetKeyUp(KeyCode.UpArrow))
    {
        myspeedScript = 0f;
        if (myspeedScript <= 0)
        {
            anim.SetFloat("Speed", myspeedScript);
            anim.Play("Idle");
            Debug.Log("UpWalk release");
        }
    }
    if (Input.GetKeyUp(KeyCode.DownArrow))
    {
        myspeedScript = 0f;
        if (myspeedScript <= 0)
        {
            anim.SetFloat("Speed", myspeedScript);
            anim.Play("Idle");
            Debug.Log("DownWalk release");
        }
    }
    if (Input.GetKeyUp(KeyCode.R))
    {
        myspeedScript = 0f;
        if (myspeedScript <= 0)
        {
            anim.SetFloat("Speed", 0);
            anim.Play("Idle");
            Debug.Log("R release");
        }
    }*/

    //rotation
    /*if (Input.GetKey(KeyCode.LeftArrow))
    {
       // gameObj.GetComponent<Animator>().Play("Walk");
        transform.Rotate(new Vector3(0, -10f*1, 0) * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
       // gameObj.GetComponent<Animator>().Play("Walk");
        transform.Rotate(new Vector3(0, 10f * 1, 0) * Time.deltaTime);
    }*/
    //}
}
