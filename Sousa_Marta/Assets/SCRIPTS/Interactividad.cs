using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactividad : MonoBehaviour
{
    public GameObject cesta;
  
    public float velocidad = 3f;

    private bool inMarginMoveX = true;
    private bool inMarginMoveZ = true;
    // Start is called before the first frame update
    void Start()
    {
        Cesta();
    }

    // Update is called once per frame
    void Update()
    {
        MoverCaja();
    }

    public void MoverCaja()
    {
        float desplX = Input.GetAxis("Horizontal");
        float desplZ = Input.GetAxis("Vertical");

        //moverse a la velocidad establecida
       // transform.Translate(Vector3.right * Time.deltaTime * velocidad * desplX);
        //transform.Translate(Vector3.forward * Time.deltaTime * velocidad * desplZ);


        float myPosX = transform.position.x;
        float myPosZ = transform.position.z;

        if (inMarginMoveX)
        {
            transform.Translate(Vector3.right * Time.deltaTime * velocidad * desplX);
        }
        if (inMarginMoveZ)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidad * desplZ);
        }

    }
        void checkRestrX(float myPosX, float desplX)
        {
            if (myPosX > -19 && desplX < 0)
            {
                inMarginMoveX = false;
            }
            else if (myPosX < 19 && desplX > 0)
            {
                inMarginMoveX = true;
            }
            else if (myPosX > -19 && desplX > 0)
            {
                inMarginMoveX = false;
            }
            else if (myPosX > 19 && desplX < 0)
            {
                inMarginMoveX = true;
            }
        }

        void checkRestrZ(float myPosZ, float desplZ)
        {
            //Retricción en Y
            if (myPosZ < -19 && desplZ < 0)
            {
                inMarginMoveZ = false;
            }
            else if (myPosZ < 19 && desplZ > 0)
            {
                inMarginMoveZ = true;
            }
            else if (myPosZ > -19 && desplZ > 0)
            {
                inMarginMoveZ = false;
            }
            else if (myPosZ > 19 && desplZ < 0)
            {
                inMarginMoveZ = true;
            }
        }
    


    public void Cesta()
    {
        if (Input.GetKey(KeyCode.C))
        {
            cesta.SetActive(true);
        }
        else
        {
            cesta.SetActive(false);
        }
    }



}
