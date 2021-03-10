using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciador : MonoBehaviour
{
    public GameObject huevos;
    private float randomNumberX, randomNumberZ;
    float numberY = 11f;

    public int contador = 0;
    public int numerohuevosrotos;
    Vector3 randomPos;
    public Transform initPos;

    [SerializeField] Text contadorHuevos;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("tiempoHuevos");
        crearHuevos();
    }

    // Update is called once per frame
    void Update()
    {

        TextoHuevos();
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

        public void TextoHuevos()
        {
            numerohuevosrotos = contador;
            contadorHuevos.text = "Nº Huevos rotos: " + numerohuevosrotos;

       /* if ( huevos.SetActive(false))
        {
            contadorHuevos.text++;
        }*/
        }

    
}
