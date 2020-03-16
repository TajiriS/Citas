using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public GameObject manager;
    Life script;
    public float evalue;
    public float ivalue;

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Master");
        script = manager.GetComponent<Life>();

    }
    // Update is called once per frame
    void Update()
    {
        /*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) == true && hit.transform.gameObject.tag == "Bolita")
            {
                Destroy(this.gameObject);
            }
        }*/

        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            script.Expectate(evalue, ivalue);
        }
    }
}
