using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject huevos;
    private float randomNumberX, randomNumberZ;
    float numberY = 11f;

    public int contador = 0;
    public int numerohuevos;
    Vector3 randomPos;
    public Transform initPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("tiempoHuevos");
        crearHuevos();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void crearHuevos()
    {
        randomNumberX = Random.Range(-18f, 18f);
        
        randomNumberZ = Random.Range(-18f, 19f);
        randomPos = new Vector3(randomNumberX, numberY, randomNumberZ);
        Vector3 finalPos = initPos.position + randomPos;
        Instantiate(huevos, finalPos, Quaternion.identity);
    }

    IEnumerator tiempoHuevos()
    {
        
        for (contador = 0; contador <= 5; contador++)
        {
            crearHuevos();
            yield return new WaitForSeconds(2f);
        }

        
        for (contador = 6; contador <= 10; contador++)
        {
            crearHuevos();
            yield return new WaitForSeconds(1f);
        }
        for (contador = 11; ; contador++)
        {
            crearHuevos();
            yield return new WaitForSeconds(0.5f);
        }




    }
}
