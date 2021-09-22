using System.Collections;
using UnityEngine;

public class CommonMethods : MonoBehaviour
{
    //This is enum
    /*    public enum Ghost
       {
           Searching,
           Attacking,
           Killing
       }
       public Ghost ghostCatch;*/
    // public GameObject gameObjects1;
    // public GameObject gameObjects2;
    // public GameObject gameObjects3;

/*    void Awake()
    {
        gameObject.SetActive(false);
        Debug.Log("Awake call");
    }*/

    void Start()
    {
        //gameObject.SetActive(false);

        /*StartCoroutine(waitAfterShow());
        Debug.Log("Start call");*/
    }

    void Update()
    {
        // objectComponentAssign();
        // commonMethodInstantiate();
        // commonMethodDestroy();
        // commonMethodEnumerator();
    }

    void objectComponentAssign()
    {
       // gameObjects2.GetComponent<Rigidbody>().useGravity = false;
    }

    void commonMethodInstantiate()
    {
        //GameObject's position != targetObject's position
        // Instantiate(gameObjects1);
        //GameObject's position != targetObject's position
        // Instantiate(gameObjects1, transform.parent);

        //GameObject's transform = targetObject's transform
        // Instantiate(gameObjects1, transform.position, transform.rotation);
        //GameObject's transform = targetObject's transform
        // Instantiate(gameObjects1, transform.position, transform.rotation, transform.parent);
    }

    void commonMethodDestroy()
    {
        //just GameObject remove
        // Destroy(gameObjects2);

        //GameObject remove after 5 second
        // Destroy(gameObjects2,5);

        //Removes this script instance(object) from the game object
        // Destroy(this);

        //Removes the rigidbody from the game object
        // Destroy(gameObjects2.GetComponent("SphereCollider"));
    }

    void commonMethodEnumerator()
    {
/*        switch (ghostCatch)
        {
            case Ghost.Searching:
                Debug.Log("Ghost searching you...");
                break;
            case Ghost.Attacking:
                Debug.Log("Ghost attacking you...");
                break;
            case Ghost.Killing:
                Debug.Log("Ghost killing you...");
                break;
        }*/
    }

    IEnumerator waitAfterShow()
    {
        yield return new WaitForSeconds(5);
        print("Game show printed after wait time");
        //method 1
         gameObject.SetActive(false);
        //method2
        // gameObjects3.SetActive(false);
    }

}
