using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{

    public Animator cubeAnim;

    // Start is called before the first frame update
    void Start()
    {
        cubeAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (!cubeAnim.GetBool("isRotating")))
        {
            cubeAnim.SetBool("isRotating", true);
        }

        else if (Input.GetKeyDown(KeyCode.Space) && (cubeAnim.GetBool("isRotating")))
        {
            cubeAnim.SetBool("isRotating", false);
        }
    }
}
