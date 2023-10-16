using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        GameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null) 
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        GameOverUI.SetActive(true);
        Debug.Log("GameOverUI");
    }
}
