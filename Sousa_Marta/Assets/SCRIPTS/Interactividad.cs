using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactividad : MonoBehaviour
{

    public float velocidad = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverCaja();
    }

    public void MoverCaja()
    {
        float desplx = Input.GetAxis("Horizontal");
        float desply = Input.GetAxis("Vertical");

        //moverse a la velocidad establecida
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * desplx);
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * desply);





    }



}
