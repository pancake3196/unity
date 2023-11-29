using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{


    void Start()
    {
        
    }

    float timer = 0f;
    void Update() 
    {
        timer += Time.deltaTime;
        RotateGameObject(new Vector3(0f, (Mathf.Cos(timer) * 0.5f + 0.5f) * 360f, 0f));
    }

    public void RotateGameObject(Vector3 rotation)
    {
        transform.Rotate(rotation);
    }

    public void MoveTranslate(Vector3 moveVector)
    {
        transform.Translate(moveVector);
    }
    public void MovePosition(Vector3 newPos)
    {
        transform.position = newPos;
    }

}
