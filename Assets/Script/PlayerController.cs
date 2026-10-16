using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Boundary{
    public float xMinimun, xMaximum, yMinimum, yMaximum;
}


public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  public Mover moverComponent;
   public float speed;
   public Boundary boundary;
   public Transform shootOrigin;
   public GameObject shootPrefab;
    public AudioClip shootSound;
private AudioSource audioSource;

   private void Start(){
        moverComponent.speed=speed;
         audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction= new Vector3(Input.GetAxis("Horizontal"),
        Input.GetAxis("Vertical"),transform.position.z);
    moverComponent.direction=direction;
      float x= Mathf.Clamp(transform.position.x, boundary.xMinimun, boundary.xMaximum);
      float y= Mathf.Clamp(transform.position.y, boundary.yMinimum, boundary.yMaximum);

      transform.position = new Vector3(x,y);  

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shootPrefab, shootOrigin, false);
              if (shootSound != null && audioSource != null)
    {
        audioSource.PlayOneShot(shootSound);
    }
        }

    }
}