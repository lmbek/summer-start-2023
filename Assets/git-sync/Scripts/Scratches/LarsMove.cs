using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarsMove : MonoBehaviour
{
    private float[] limits = new float[2]{-1f, 1f};
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        (float h, float v) = GetInput();
        Move(h, v);
    }

    (float, float) GetInput() 
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        return (h,v);
    }

    void Move(float horizontalInput,float verticalInput) 
    {
        horizontalInput = Mathf.Clamp(horizontalInput, -1f, 1f);
        verticalInput = Mathf.Clamp(verticalInput, -1f, 1f);
        transform.Translate(new Vector3(horizontalInput*speed*Time.deltaTime,0,verticalInput*speed*Time.deltaTime));  
    }
}
