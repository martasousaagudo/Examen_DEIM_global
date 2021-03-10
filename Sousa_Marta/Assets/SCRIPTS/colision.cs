using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    Instanciador instanciador;
    public int resta;
    // Start is called before the first frame update
    void Start()
    {
        instanciador = GameObject.Find("Instanciador").GetComponent<Instanciador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Egg_FBX")
        {
            resta++;
            Destroy(gameObject);
        }
    }
}
