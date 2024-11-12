using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    static float timer = 5.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + new Vector3(0.0f, 0.0f, 1.0f / timer);
        transform.position = newPosition;

        timer -= Time.deltaTime;
    }
}
