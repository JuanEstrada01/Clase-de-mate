using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnitud : MonoBehaviour
{
    public enum Operacion { Suma, Resta, Multi, Division }
    [Header("Vector")]
    [SerializeField] private float x, y, z;
    
    public float magnitud;
    public float Normalizarx;
    public float Normalizary;
    public float Normalizarz;
    public GameObject Sphere;
    public float x1, y1, z1;
    public float Distanciax;
    public float Distanciay;
    public float Distanciaz;



    // Start is called before the first frame update
    void Start()

    {

    


    }

    // Update is called once per frame
    void Update()
    {
        
       
        magnitud = Mathf.Sqrt((x * x) + (y * y) + (z * z));
        Debug.Log("El resultado de la Magnitud es" + magnitud);


        //Normalizacion 
        Normalizarx = x / magnitud;
        Normalizary = y / magnitud; 
        Normalizarz = z / magnitud;

        //Distancia
        x1 = Sphere.transform.position.x;
        x1 = Sphere.transform.position.y;

        x1 = Sphere.transform.position.z;

        Distanciax = x - x1;
        Distanciax = x -y1;
        Distanciax = x - z1;




    }
}
