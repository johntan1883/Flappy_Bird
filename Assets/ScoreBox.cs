using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    private ScoreManager _scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        //find object
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        { return; }

        if (_scoreManager == null)
            return;

        _scoreManager.AddScore();
    }

}
