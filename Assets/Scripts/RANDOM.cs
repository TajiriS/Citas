using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RANDOM : MonoBehaviour
{
    public GameObject Bolita;
    public GameObject[] BolitaList;

    private void Start()
    {
        StartCoroutine("Spawnear");
    }
    public void Update()
    {
        //BolitaList = GameObject.FindGameObjectsWithTag("Expectation");
        if (BolitaList.Length == 0) BolitaSpawn();
        Debug.Log(BolitaList.Length);
        
    }

    public void BolitaSpawn()
    {
        //for (int i = 0; i < 5; i++)
        //{
            Vector2 randomSpawn = new Vector2(Random.Range(-2.77f, 4.67f), Random.Range(-7.5f, 7.5f));
            Instantiate(Bolita,randomSpawn, transform.rotation);
        //}
    }

    IEnumerator Spawnear()
    {
        yield return new WaitForSeconds(2);
        BolitaSpawn();
        StartCoroutine("Spawnear");
    }

    

}
