using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D capsula;

    public float velocidad = 10f;
    Vector2 posicionObjetivo;



    // Use this for initialization
    void Start()
    {

        posicionObjetivo = transform.position;
        capsula = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        movimientoTeclas();
        Vector2 mousePosition = Input.mousePosition;
    
        
    if (Input.GetMouseButton(0)){
        posicionObjetivo = Camera.main.ScreenToWorldPoint(mousePosition);
        }

        gameObject.transform.position = Vector2.MoveTowards(transform.position, new Vector2(posicionObjetivo.x, transform.position.y), velocidad * Time.deltaTime ); // conversion unid/sec a unid/frame


    }

    void movimientoTeclas()
    {

        float horizontal = Input.GetAxis("Horizontal");

        capsula.velocity = velocidad * new Vector2(horizontal, capsula.velocity.y)
            ;
    }
    





}
