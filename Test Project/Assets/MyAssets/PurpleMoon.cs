using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleMoon : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 14 * Time.deltaTime);
        transform.Rotate(Vector3.back * Time.deltaTime * 2);

    }
}
