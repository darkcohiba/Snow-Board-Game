using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject ball;

    void LateUpdate()
    {
        transform.position = ball.transform.position + new Vector3(0, 0, -10);
    }
}
