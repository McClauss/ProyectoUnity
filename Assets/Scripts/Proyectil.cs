using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speedP = 0.0002f;
    public Vector3 direccionP=new Vector3(5f,0,0);
    public int damage=2;
    float escalaX=0.25f;
    float escalaY=0.25f;
    float escalaZ=0.25f;
    
    void Update()
    {
        transform.position += direccionP*speedP;
        if(Input.GetKeyDown(KeyCode.Space)){
            DuplicaTamano();
        }   
    }

    void DuplicaTamano(){
        transform.localScale += new Vector3(escalaX*2,escalaY*2,escalaZ*2);
    }
}
