using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 300, 2000));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
