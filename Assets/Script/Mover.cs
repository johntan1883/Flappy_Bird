using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float MoveSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<=-15)
            Destroy(gameObject);

        Vector2 targetMovePostion = transform.position;
        targetMovePostion.x -=MoveSpeed* Time.deltaTime;

        transform.position = targetMovePostion;
    }
}
