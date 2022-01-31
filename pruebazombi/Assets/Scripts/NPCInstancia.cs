using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInstancia : MonoBehaviour
{
    public GameObject zombi;

    [SerializeField] GameObject[] instArray;

    // Start is called before the first frame update
    void Start()
    {
        instArray = GameObject.FindGameObjectsWithTag("ZombiPos");

       for (int n = 0; n < 20; n++)
        {
            Instantiate(zombi, instArray[n].transform.position, Quaternion.identity);
        }
      

    }

    // Update is called once per frame
    void Update()
    {

    }
}
