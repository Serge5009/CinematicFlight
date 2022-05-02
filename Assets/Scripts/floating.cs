using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float value;
    float distance = 0;
    

    void Update()
    {
        Vector3 change = new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        transform.position += change;
        distance += speed * Time.deltaTime;

        if (distance >= value || distance <= 0)
            speed = -speed;
    }
}
