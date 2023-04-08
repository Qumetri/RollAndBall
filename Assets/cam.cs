using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    Vector3 offset;

    void Start()
    {
        offset = target.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position - offset;
    }
}
