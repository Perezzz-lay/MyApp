using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public float speedmove = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float
            horInput = Input.GetAxis("Horizontal"),
            verInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horInput, 0.0f, verInput);
        transform.Translate(direction * speedmove * Time.deltaTime);
    }
}
