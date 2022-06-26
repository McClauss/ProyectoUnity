using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    public float delay=15f;
    
    void Start()
    {
        Destroy(gameObject,delay);
    }

    void Update()
    {
        
    }
}
