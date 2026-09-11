using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour
{
    //Añadimos referencia al componente mover
    public Mover mover;

    private void Update()
    {
        Vector3 desplazamiento = new Vector3(
            UnityEngine.Random.Range(-1f, 1f),
            UnityEngine.Random.Range(-1f, 1f),
            transform.position.z
        );

        mover.DoMove(desplazamiento);
    }
}
