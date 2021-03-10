using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    public GameObject caja;
    [SerializeField] Transform cubo;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cubo.position.x, transform.position.y, transform.position.z);
        

    }
}
