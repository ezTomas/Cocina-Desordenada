using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Desordenar : MonoBehaviour
{
    [SerializeField] private float fuerzaMinima = 10f;
    [SerializeField] private float fuerzaMaxima = 20f;

    private float timer;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Disparar()
    {
        Physics.IgnoreLayerCollision(0, 0, false);

        Vector3 direccionAleatoria = Random.onUnitSphere;

        float fuerzaFinal = Random.Range(fuerzaMinima, fuerzaMaxima);

        rb.AddForce(direccionAleatoria * fuerzaFinal, ForceMode.Impulse);

        timer += Time.deltaTime;

        if (timer >= 5f) 
        {
            Physics.IgnoreLayerCollision(0, 0, true);
        }
        
    }
}

