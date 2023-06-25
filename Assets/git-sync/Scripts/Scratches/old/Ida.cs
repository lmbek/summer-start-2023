using Assets.git_sync.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ida : MonoBehaviour
{
    public List<GameObject> boxes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // interact button --> create square 
        if (Input.GetKeyDown(KeyCode.E))
        {
            //GameObject gameObject = new GameObject();
            GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
            box.name = "box";
            box.transform.position = new Vector3(5, 0, 0);
            box.AddComponent<Rigidbody>();
            box.AddComponent<IdaBox>();
            boxes.Add(box);
        }

        // when pressing A or D
        if (Input.GetAxis("Horizontal") > -1 && Input.GetAxis("Horizontal") < 1)
        {
            //Debug.Log("AD");
        }

        // when pressing W or S 
        if (Input.GetAxis("Vertical") > -1 && Input.GetAxis("Vertical") < 1)
        {
            //Debug.Log("WS");
        }
    }

    void OnDrawGizmosSelected()
    {
        //foreach (GameObject box in boxes)
        //{
        //    // draw a red sphere at the transforms position 
        //    Gizmos.color = Color.red;
        //    Gizmos.DrawSphere(box.transform.position, 0.3f);
        //}
    }
}
