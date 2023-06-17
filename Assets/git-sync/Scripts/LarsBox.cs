using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LarsBox : MonoBehaviour
{
    // OnDrawGizmosSelected is a method that runs in the Editor scene (not in game scene)
    // if gizmos is set to on inside the inspector
    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = new Color(1f, 0.8f, 0.9f);
        Gizmos.DrawSphere(transform.position, 3f);
    }
}
