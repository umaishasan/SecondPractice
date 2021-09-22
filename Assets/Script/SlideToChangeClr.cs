using System.Collections;
using UnityEngine;

public class SlideToChangeClr : MonoBehaviour
{
    public float Val;
    public GameObject g1, g2, g3;

    void Update()
    {
        ValueChangeCube(Val);
        StartCoroutine(CubeRotate());
    }
    public void ValueChangePlane(float slideVal)
    {
        Val = slideVal;
        g1.GetComponent<Renderer>().material.color = new Color(0.07058824f, 0.2214756f, 0.3137255f, Val);
        Debug.Log("ValueChangePlane method call" + Val);
    }
    public void ValueChangeHuman(float slideVal)
    {
        Val = slideVal;
        g2.GetComponent<Renderer>().material.color = new Color(0, 0, 0, Val);
        Debug.Log("ValueChangePlane method call" + Val);
    }
    public void ValueChangeCube(float slideVal)
    {
        Val = slideVal;
        if (Val == 0f)
        {
            g3.transform.Rotate(Vector3.up*0);
            //g3.transform.Rotate(new Vector3(-1.57f, 0.79f, -10.61f));
        }
        Debug.Log("ValueChangePlane method call" + Val);
    }

    IEnumerator CubeRotate()
    {
        yield return new WaitUntil(()=> Val == 1);
        g3.transform.Rotate(Vector3.up * 80);
        Debug.Log("Coroutine method call" + Val);
    }
}
