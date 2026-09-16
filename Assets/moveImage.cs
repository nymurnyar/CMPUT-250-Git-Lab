using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveImage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 10f * Time.deltaTime);

        // this is a line of comment i am adding to demo the rebase stuff
    }
}
