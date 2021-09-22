using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScripts : MonoBehaviour
{
    //ARRAY
    // public GameObject[] gameObj;

    //LIST
    public List<GameObject> gameObjList = new List<GameObject>();

    public float distance;
    public GameObject ball;

    void Update()
    {
        deduct();
    }

    //LIST
    void deduct()
    {
        RaycastHit hiting;
        if (Physics.Raycast(transform.position, transform.forward, out hiting, distance))
        {
            for (int i = 0; i < gameObjList.Count; i++)
            {
                if (hiting.collider.gameObject == gameObjList[i].gameObject)
                {
                    Debug.DrawRay(transform.position, MovigrayAcctoObj(gameObjList[i].name = "Wall" + (i + 1)), Color.red);
                    DestroyObj(gameObjList[i], "Wall" + (i + 1));
                    Debug.Log(hiting.collider.gameObject.name);
                }
            }
        }
        else
        {
            Debug.DrawRay(transform.position, Vector3.back, Color.green);
        }
    }

    //ARRAY
    /*    void deduct()
        {
            RaycastHit hiting;
            if (Physics.Raycast(transform.position, transform.forward, out hiting, distance))
            {
                for(int i=0;i< gameObj.Length; i++)
                {
                    if (hiting.collider.gameObject == gameObj[i].gameObject)
                    {
                        Debug.DrawRay(transform.position, MovigrayAcctoObj(gameObj[i].name = "Wall" + (i + 1)), Color.red);
                        DestroyObj(gameObj, "Wall"+(i+1));
                        Debug.Log(hiting.collider.gameObject.name);
                    }
                }
            }
            else
            {
                Debug.DrawRay(transform.position, Vector3.back, Color.green);
            }
        }*/


    //COMMON
    Vector3 MovigrayAcctoObj(string wallName)
    {
        if(wallName == "Wall1")
        {
            return Vector3.forward;
        }
        if (wallName == "Wall2")
        {
            return Vector3.right;
        }
        if (wallName == "Wall3")
        {
            return Vector3.left;
        }
        return Vector3.one;
    }

    //FOR LIST
    void DestroyObj(GameObject colide,string wallName)
    {
        if (Input.GetMouseButtonDown(0))
        {
            ball.SetActive(true);
            ball.transform.position = new Vector3(0, 0, 10);
            ball.SetActive(false);
            if(colide.gameObject.name == wallName)
            {
                //colide[i].SetActive(false);
                Destroy(colide);
                Debug.Log("Destroy" + colide);
            }
        }
    }

    //FOR ARRAY
    /*void DestroyObj(GameObject[] colide, string wallName)
    {
        if (Input.GetMouseButtonDown(0))
        {
            ball.SetActive(true);
            ball.transform.position = new Vector3(0, 0, 10);
            ball.SetActive(false);
            for (int i = 0; i < colide.Length; i++)
            {
                if (colide[i].gameObject.name == wallName)
                {
                    //colide[i].SetActive(false);
                    Destroy(colide[i]);
                    Debug.Log("Destroy" + colide[i]);

                }
            }
        }
    }*/
}
