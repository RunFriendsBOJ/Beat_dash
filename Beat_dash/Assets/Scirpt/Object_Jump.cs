using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) Jump();
    }
    void Jump()
    {
        transform.Translate(0.0f, 0.3f, 0.0f);
    }
}
