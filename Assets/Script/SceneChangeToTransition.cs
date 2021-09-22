using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeToTransition : MonoBehaviour
{
    void LoadNextScene()
    {
        SceneManager.LoadScene("", LoadSceneMode.Single);
    }
}
