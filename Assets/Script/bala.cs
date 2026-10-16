using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public AudioClip sonidoImpacto;

      private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Colision detectada con: " + other.name);
        if (other.CompareTag("Enemigo"))
        {
             Debug.Log("Es un enemigo");
  // Reproducir sonido de impacto
            if (sonidoImpacto != null)
            {
                 Debug.Log("Reproduciendo sonido: " + sonidoImpacto.name);
                AudioSource.PlayClipAtPoint(
                    sonidoImpacto,
                        Camera.main.transform.position,
    1f
                );
            } else{  Debug.LogWarning("No hay sonido asignado");}



            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }


}
