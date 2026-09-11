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
   

    // Update is called once per frame
    void Update()
    {
        Vector3 desplazamiento= new Vector3(Input.GetAxis("Horizontal")*speed*Time.deltaTime,
        Input.GetAxis("Vertical")*speed*Time.deltaTime,transform.position.z);
    moverComponent.DoMove(desplazamiento);
      float x= Mathf.Clamp(transform.position.x, boundary.xMinimun, boundary.xMaximum);
      float y= Mathf.Clamp(transform.position.y, boundary.yMinimum, boundary.yMaximum);

      transform.position = new Vector3(x,y);  
    }
}