using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed=2;
    void Start()
    {
        
    }

    
    void Update()
    {
        MovimientoJugador();
    }
    
    //Función para mover jugador con Teclado (Felchas y AWSD)
    void MovimientoJugador(){
        float hor= Input.GetAxis("Horizontal");//Lee Eje Horizontal
        float ver= Input.GetAxis("Vertical");//Lee Eje Vertical

        Debug.Log("Horizontal" + hor);
        Debug.Log("Vertical" + ver);

        transform.Translate(new Vector3(hor,0,ver)*speed*Time.deltaTime);
    }
}
