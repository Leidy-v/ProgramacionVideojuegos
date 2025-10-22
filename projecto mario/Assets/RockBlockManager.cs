using UnityEngine;
using System.Collections;

public class RockBlockManager : MonoBehaviour
{
    public static RockBlockManager instancia;

    [Header("Sincronización global")]
    public bool bajandoGlobal = true;
    public bool enPausaGlobal = false;

    public float pausaAbajo = 0.5f;
    public float pausaArriba = 1f;

    void Awake()
    {
        instancia = this;
        StartCoroutine(CicloGlobal());
    }

    IEnumerator CicloGlobal()
    {
        while (true)
        {
            enPausaGlobal = true;
            yield return new WaitForSeconds(bajandoGlobal ? pausaAbajo : pausaArriba);
            bajandoGlobal = !bajandoGlobal;
            enPausaGlobal = false;
        }
    }
}
