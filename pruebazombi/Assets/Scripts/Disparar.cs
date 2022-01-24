using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    InputMove inputmove;
    [SerializeField] float balaspeed = 0.5f;
    [SerializeField] Transform initpos;
    // Start is called before the first frame update
    void Start()
    {
        inputmove = GameObject.Find("Survivor").GetComponent<InputMove>();

    }

    // Update is called once per frame
    void Update()
    {
       // initpos = transform.position;
        transform.Translate(Vector3.forward * balaspeed * Time.deltaTime);
        Destroy(gameObject, 20f);
    }
}
