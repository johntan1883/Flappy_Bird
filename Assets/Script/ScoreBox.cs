using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    private ScoreManager _scoreManager;
    public AudioSource _AudioSource;

    void Start()
    {
        _AudioSource = GetComponent<AudioSource>();
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag ("Player"))
        {  return; }

        if (_scoreManager == null)
            return;
        _scoreManager.AddScore();

        if(_AudioSource != null)
        _AudioSource.Play();
    }
}


