using UnityEngine;

public class testClases : MonoBehaviour
{

    enum TipoArmas
    {
        m16,
        glock,
        ak47,
        AA12,
        SPAS12
    };

    float weaponDamage = 20f;
    TipoArmas armaActual;
    

    void Start()
    {
       switch(armaActual){
            case TipoArmas.m16:
            weaponDamage=40;
            break;
            case TipoArmas.glock:
            weaponDamage=10;
            break;
            case TipoArmas.ak47:
            weaponDamage=25;
            break;
            case TipoArmas.AA12:
            weaponDamage=30;
            break;
            case TipoArmas.SPAS12:
            weaponDamage=35;
            break;
            default:
            weaponDamage=0;
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
