using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegarObjetos : MonoBehaviour {

    Rigidbody2D Objeto;
    public List<GameObject> arrayObjetos = new List<GameObject>();
    GameObject ultimoObjeto;
    public GameObject disparador;

    

    // Use this for initialization
    void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){

            ultimoObjeto = arrayObjetos[arrayObjetos.Count - 1];

            Objeto.simulated = true;
            Objeto.AddForce(new Vector2(150f, 150f));
            transform.DetachChildren();

        }
        
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.CompareTag("Objeto")){

            arrayObjetos.Add(collision.gameObject);


            Objeto = collision.gameObject.GetComponent<Rigidbody2D>();
            Objeto.simulated = false;
            collision.transform.parent = transform;
            

        }
	}
}
