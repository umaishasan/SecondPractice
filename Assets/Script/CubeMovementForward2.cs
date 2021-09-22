using UnityEngine;

public class CubeMovementForward2 : MonoBehaviour
{
    public float myspeedScript;

    // Update is called once per frame
    void Update()
    {
       
        move();
    }

    //FROM KEYBOARD MOVE
    void move()
    {
        //movement for key down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("UpWalk");
            transform.Translate(new Vector3(0, 0, 4f * myspeedScript) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("DownWalk");
            transform.Translate(new Vector3(0, 0, -4f * myspeedScript) * Time.deltaTime);
        }

        //rotation
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -10f * 1, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 10f * 1, 0) * Time.deltaTime);
        }
    }
}
