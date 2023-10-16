using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    public AudioSource _AudioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        { return; }
        Destroy(collision.gameObject);
        Pause();
        if (_AudioSource != null)
        _AudioSource.Play();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        Debug.Log("Pause");
    }

    
}
