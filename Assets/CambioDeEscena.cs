using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Recordad poned esto para que funcione.

public class cambiodeescena : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Casita"); // Poned aquí el nombre de vuestra escena.
        }
    }

}