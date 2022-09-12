using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class CameraMove : MonoBehaviour
    {
        Vector3 targetPosition;

        // Start is called before the first frame update
        void Start()
        {
            targetPosition = new Vector3(0, 1, 0);
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime);
        }
    }
}
