using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float maximumZ;
    public float minimumZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += transform.forward * 0.1f;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position -= transform.forward * 0.1f;
        }

        if (transform.position.z > maximumZ) {
            Vector3 pos = transform.position;
            pos.z = maximumZ;
            transform.position = pos;
        } else if (transform.position.z < minimumZ) {
            Vector3 pos = transform.position;
            pos.z = minimumZ;
            transform.position = pos;
        }
        
    }
}
