using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoManhã : MonoBehaviour {
    public GameObject canvas;
    public GameObject personagem;

	// Use this for initialization
	void Start () {
        personagem.SetActive(false);
        canvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 0)
            transform.Translate(Vector3.left * Time.deltaTime);
        else
        { 
            canvas.SetActive(true);
            personagem.SetActive(true);
        }
    }
}   
