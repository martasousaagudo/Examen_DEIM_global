using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovHuevo : MonoBehaviour
{
    private float velocidadHuevo;
    public GameObject Cube;
    Interactividad movimientoHuevo;
    // Start is called before the first frame update
    void Start()
    {
        Cube = GameObject.Find("Egg_FBX");
        movimientoHuevo = Cube.GetComponent<Interactividad>();
    }

    // Update is called once per frame
    void Update()
    {
        float PosY = transform.position.y;
        if(PosY < -2)
        {
            Destroy(gameObject);
        }
    }
}
