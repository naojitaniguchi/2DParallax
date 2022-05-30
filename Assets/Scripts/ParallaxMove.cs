using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMove : MonoBehaviour
{
    public float rate = 0.3f;
    public GameObject targetCamera;
    Vector3 lastCameraPos;
    // Start is called before the first frame update
    void Start()
    {
        lastCameraPos = targetCamera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = targetCamera.transform.position.x - lastCameraPos.x;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + x * rate, gameObject.transform.position.y, gameObject.transform.position.z);

        lastCameraPos = targetCamera.transform.position;
    }
}
