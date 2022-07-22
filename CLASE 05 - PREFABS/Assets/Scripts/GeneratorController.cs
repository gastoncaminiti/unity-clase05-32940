using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    //Propiedades para configurar el generador de enemigos.
    //public GameObject enemyPrefab;
    public GameObject[] enemyPrefabs;
    public float delaySpawn = 2f;
    public float intervalSpawn = 2f;

    void Start()
    {
        //Invoke nos permite llamar a un método una única vez con un delay inicial.
        //Invoke("SpawnEnemy", delaySpawn);
        //InvokeRepeating nos permite llamar de forma REPETIDA a un método.
        InvokeRepeating("SpawnEnemy", delaySpawn, intervalSpawn);
        //                Método        Espera    Tiempo de Repetición
    }


    //Update is called once per frame
    void Update()
    {

    }
    
    //Método para instanciar un enemigo de forma aleatoria.
    private void SpawnEnemy()
    {
        //Seleccionamos la posición de un enemigo en el listado de enemigos.
        int indexEnemy = Random.Range(0, enemyPrefabs.Length);
        //Instantiate nos permite crear un GameObject en la escena.
        Instantiate(enemyPrefabs[indexEnemy], transform);
    }


}
