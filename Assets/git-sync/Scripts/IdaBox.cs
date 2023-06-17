using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.git_sync.Scripts
{
    public class IdaBox : MonoBehaviour
    {
        void OnDrawGizmosSelected()
        {
            // draw a red sphere at the transforms position 
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, 3);
        }
    }
}
