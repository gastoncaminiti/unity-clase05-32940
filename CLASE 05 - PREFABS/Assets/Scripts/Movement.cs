using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Propiedades para configurar dirección y velocidad
    public Vector3 direction = new Vector3(0f, 0f, 1f); // vector3.Forward
    public float speed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //Método para mover el trasform usando la posicion.
    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
