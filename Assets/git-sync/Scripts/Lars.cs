using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lars : MonoBehaviour
{
    public List<GameObject> boxes = new List<GameObject>();


    void Awake() {

    }

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        // When pressing E
        if(Input.GetKeyDown(KeyCode.E))
        {
            //GameObject gameObject = new GameObject();
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.name = "Vores Box";
            box.transform.position = new Vector3(5,0,0);
            box.AddComponent<Rigidbody>();
            box.AddComponent<LarsBox>();
            boxes.Add(box);
        }

        // When pressing A or D
        if(Input.GetAxis("Horizontal")>-1 && Input.GetAxis("Horizontal")<1)
        {
            //Debug.Log("Moved Horizontal by: "+Input.GetAxis("Horizontal"));
        }

        // When pressing W or S
        if(Input.GetAxis("Vertical")>-1 && Input.GetAxis("Vertical")<1)
        {
            //Debug.Log("Moved Vertical by: "+Input.GetAxis("Vertical"));
        }
    }

    // OnDrawGizmosSelected is a method that runs in the Editor scene (not in game scene)
    // if gizmos is set to on inside the inspector
    void OnDrawGizmosSelected()
    {
        /*
        foreach(GameObject box in boxes){
            // Draw a yellow sphere at the transform's position
            Gizmos.color = new Color(1f, 0.8f, 0.9f);
            Gizmos.DrawSphere(box.transform.position, 0.3f);
        }
        */
    }
}
