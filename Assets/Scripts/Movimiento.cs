using UnityEngine;

public class Movimiento : MonoBehaviour
{

    int cantidadMonedas=0;



    public float speed=2;

    public Transform posEnemigo;

    //public Transform puerta;

    Vector3 posInicial;//Guarda posicioon inicial del jugador

    int numeroRandom=0;
    

    void Start()
    {
        TestMatematicaVectores();
        posInicial=transform.position;
    }

    
    void Update()
    {
        MovimientoJugador();
        //ChequearDistancia();
        /*Evalua si el jugador cayo del escenario*/
        if(transform.position.y <-10){
            Respawn();
        }
        //numeroRandom=Random.Range(0,20);
        //puerta.transform.position=new Vecor3(numeroRandom,numeroRandom,numeroRandom);
    }
    
    //Función para mover jugador con Teclado (Felchas y AWSD)
    void MovimientoJugador(){
        float hor= Input.GetAxis("Horizontal");//Lee Eje Horizontal
        float ver= Input.GetAxis("Vertical");//Lee Eje Vertical

        //Debug.Log("Horizontal" + hor);
        //Debug.Log("Vertical" + ver);

        transform.Translate(new Vector3(0,0,ver)*speed*Time.deltaTime);//Captura Posiicon Inicial del Jugador
        transform.Rotate(0,hor,0);
        //transofrm.position += new Vector3();        
    }

    void TestMatematicaVectores(){
        Vector3 vectorUno = new Vector3(1,1,1);
        Vector3 vectorDos = new Vector3(0,5,2);

        Vector3 resultado = vectorUno + vectorDos;//suma cada componente de ambos vectores
        Debug.Log("Resultado es: "+resultado);
        Debug.Log("Magnitud Vector Resultado es: "+resultado.magnitude);//saca magnitud
        Debug.Log("Vector Normalizado es: "+resultado.normalized);//normaliza el vector
    }
    /*Funcion para Calcular Distancia Contra un Objeto*/
    void ChequearDistancia(){
        float distancia=Vector3.Distance(transform.position,posEnemigo.position);//mide distancia entre posicion vs posicion dos
        Debug.Log("Distancia Contr< Objetivo: "+ distancia);

        if (distancia<3){
            Debug.Log("Enemigo Próximo: "+ distancia);
        }
    }
    //Método Propio de Trigger para el Tema deteccion de Coliciones Ejemplo: Manejo de Monedas

    //Tambien hay OnTriggerStay (Colicion Constante) y OnTriggerExit Colicion al Salir
    void OnTriggerEnter(Collider col){
        
        if(col.transform.gameObject.tag == "Moneda"){
            cantidadMonedas++;
            Debug.Log("He colicionado con una Moneda. "+cantidadMonedas);
            //col.transform.gameObject.SetActive(false);
            Destroy(col.transform.gameObject);
        }

        if(col.transform.gameObject.tag == "Pinchos"){
            cantidadMonedas++;
            Debug.Log("He colicionado con un Pincho. ");
            Respawn();
        }
    }

    /*Metodo para Respawn al Jugador*/
    void Respawn(){
        transform.position=posInicial;
    }

}
