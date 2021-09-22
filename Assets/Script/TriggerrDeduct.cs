using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerrDeduct : MonoBehaviour
{
    //ARRAY
    //public GameObject[] triggerDeductObj;

    //LIST
    public List<GameObject> gameObjList = new List<GameObject>();

    public AudioSource audio;

    void OnTriggerEnter(Collider other)
    {
        for(int i=0;i< gameObjList.Count;i++)
        {
            gameObjList[i].SetActive(true);
        }
            audio.Play();
            Debug.Log("Triggered");
    }

    void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < gameObjList.Count; i++)
        {
            gameObjList[i].SetActive(false);
        }
        Debug.Log("Triggered Exit");
    }

//ARRAY 
/*    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < triggerDeductObj.Length; i++)
        {
            triggerDeductObj[i].SetActive(true);
        }
        audio.Play();
        Debug.Log("Triggered");
    }

    void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < triggerDeductObj.Length; i++)
        {
            triggerDeductObj[i].SetActive(false);
        }
        Debug.Log("Triggered Exit");
    }*/
}
