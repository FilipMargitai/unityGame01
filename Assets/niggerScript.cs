using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class niggerScript : MonoBehaviour
{
    private int i;
    public int c = 2;
    public GameObject Gay;
    public GameObject gay;
    // Start is called before the first frame update
    void Start()
    {
        //Gay.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("nigger" + i);
        i++;

        gay.GetComponent<Rigidbody>().AddForce(new Vector3(10,0,0));
    }
}
