using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour
{
    public Animator boxAnim;

    // Start is called before the first frame update
    void Start()
    {
        boxAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            boxAnim.SetTrigger("Toggle");
        }


    }
}
