using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCustomEvents : MonoBehaviour
{
    public UnityEvent player2;
    public GameObject targetPlayer1;
    public GameObject targetPlayer2;

    void Awake()
    {
        targetPlayer1.SetActive(true);
        targetPlayer2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        playerOnTrigger();
    }

    void playerOnTrigger()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            targetPlayer1.SetActive(false);
            targetPlayer2.SetActive(true);
            player2.Invoke();
            Debug.Log("Player1 Deactivated & Player2 Activated Custom-Event call at Player2");
        }
    }
}
