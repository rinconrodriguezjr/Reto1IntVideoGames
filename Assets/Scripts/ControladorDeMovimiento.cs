using UnityEngine;

public class ControladorDeMovimiento : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento horizontal
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        rb.velocity = movimiento * velocidad;
    }
}

