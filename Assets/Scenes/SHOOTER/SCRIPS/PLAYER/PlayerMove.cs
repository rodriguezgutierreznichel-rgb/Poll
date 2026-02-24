using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    public float velocidadDelMovimiento = 0;

    public Animator animator;

    

    void Start()
    {
        animator = GetComponent<Animator>();

        
    }

    void Update()
    {
        PersonajeMove();
    }

    public void PersonajeMove()
    {
        
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadDelMovimiento;
        movimientoEjeX = Input.GetAxis("Vertical") * Time.deltaTime * velocidadDelMovimiento;

        
        transform.Translate(movimientoEjeZ, movimientoEjeY, movimientoEjeX);

        
        if (movimientoEjeZ != 0 || movimientoEjeX != 0)
        {
            animator.SetBool("Correr", true);
        }
        else
        {
            animator.SetBool("Correr", false);
        }
    }

}
