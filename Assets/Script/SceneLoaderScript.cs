using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;

    public void SceneLoad()
    {

        StartCoroutine(SceneNextInDelay(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator SceneNextInDelay(int SceneIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(SceneIndex);
    }
}
