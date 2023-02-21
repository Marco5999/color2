using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject cubeColor;
    public Color color1, color2, color3;

    public bool isChanged = false;
    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag.Equals("Bullet")) 
        {
            if(isChanged == false)
            {
                GetComponent<SpriteRenderer>().color = color1;
                isChanged = true;
            }
            else if(isChanged == true)
            {
                GetComponent<SpriteRenderer>().color = color2;
                isChanged = false;
            }
            else if (isChanged == false)
            {
                GetComponent<SpriteRenderer>().color = color3;
                isChanged = true;
            }
            //GetComponent<SpriteRenderer>().color = color1; 
            //GetComponent<SpriteRenderer>().color = Color.red;
           // Destroy(col.gameObject);

        }
    }
    private void Update()
    {
        //if(GameObject.FindGameObjectWithTag("Cube").color == Color.red)
        {

        }
    }
    



}
