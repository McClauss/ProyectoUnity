using UnityEngine;

public class Rafaga : MonoBehaviour
{

    public GameObject prefabEscombro;

    public Transform posicionHueco1;
    public Transform posicionHueco2;

    public float tiempoRafaga=5f;
    public float tiempoRestante;

    void Start()
    {
        ResetearTemporizador();
    }

    void Update()
    {
        CrearProyectil();
        Temporizador();
    }

    //Funcion para crear dos proyectiles Oprimiendo Teclas O y P
    void CrearProyectil(){
        
        if(Input.GetKeyDown(KeyCode.O)){
            Instantiate(prefabEscombro,posicionHueco1.position,transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.P)){
            Instantiate(prefabEscombro,posicionHueco2.position,transform.rotation);
        }
    }

    //Funcion para reiniciar temporizador y disparar Ráfaga
    void ResetearTemporizador(){
        Instantiate(prefabEscombro,posicionHueco1.position,transform.rotation);
        Instantiate(prefabEscombro,posicionHueco2.position,transform.rotation);
        tiempoRestante = tiempoRafaga;
    }

    //Funcion que hace conteo de temporizador
    void Temporizador(){
        tiempoRestante -= Time.deltaTime;//Contador en descenso
        if (tiempoRestante <=0){
    //  Debug.Log(" Tiempo Agotado");
        ResetearTemporizador();
        }
    }
}
