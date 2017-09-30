using UnityEngine;
using System.Collections;

public class Background1 : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.1f, 0, 0);
        if (transform.position.x < -20.8f)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}