using System;
using UnityEngine;

public class ControladorDeDisparo : MonoBehaviour
{
    [SerializeField] private string tagObjetivo;
    [SerializeField] private string tagAIgnorar;

    public void DispararTodos()
    {
        GameObject[] objetosEncontrados = GameObject.FindGameObjectsWithTag(tagObjetivo);

        foreach (GameObject obj in objetosEncontrados)
        {
            if (obj.TryGetComponent<Desordenar>(out Desordenar script3D))
            {
                script3D.Disparar();

            }
        }
    }
}