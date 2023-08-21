using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeL : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(1))
        {
            target.SetActive(true);
            this.   gameObject.SetActive(false);
        }
    }
}
