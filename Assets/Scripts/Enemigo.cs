using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public Transform posEnemigo;
    public GameObject objeto1;

    /*
    private float enemySpeed = 1.25f;
    [SerializedField]*/
    public float enemySpeed = 1.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChequearDistancia();
        LookAtPlayerQuat();
        //SegguirJugador();
        SeguirLerp();
    }

    /*Funcion para Calcular Distancia Contra un Objeto*/
    void ChequearDistancia(){
        float distancia=Vector3.Distance(transform.position,posEnemigo.position);//mide distancia entre posicion vs posicion dos
        Debug.Log("Distancia Contra Objetivo: "+ distancia);

        /*Aparece/Desaparece Objeto de acuerdo a proximidad*/
        if (distancia<10){
            Debug.Log("Enemigo Próximo: "+ distancia);
            objeto1.SetActive(true);
        }
        else
        {
            objeto1.SetActive(false);
        }
    }
    /*Funcion para que mire al jugador*/
    void LookAtPlayerQuat(){
       
        /*Opcion1 Usando QWuaternion
        Quaternion rotacion = Quaternion.LookRotation(posEnemigo.position-transform.position);
        transform.rotation=rotacion;
        */
        /*Opcion2 sin Usar Quaternion*/
        transform.LookAt(posEnemigo);
    }
    /*Funcion para Seguir al Jugador*/
    void SegguirJugador(){
        transform.position = Vector3.MoveTowards(transform.position,posEnemigo.position,enemySpeed* Time.deltaTime);
    }
    /*Funcion para que el seguimiento no sea a velocidad constante, que se vaya disminuyendo cuando se acerca  **** Lo contrarioo seria con Flerp*/
    void SeguirLerp(){
        transform.position = Vector3.Lerp(transform.position,posEnemigo.position,enemySpeed* Time.deltaTime);
    }
}
