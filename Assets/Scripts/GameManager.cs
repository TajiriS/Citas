using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject manager;
    Life script;
    public float expect;
    public float interest;

    // Start is called before the first frame update
    void Start()
    {
        script = manager.GetComponent<Life>();
    }

    // Update is called once per frame
    void Update()
    {
        if(script.Expectation <= expect)
        {
            Lose();
        }
        if(script.Interest >= interest)
        {
            Win();
        }
    }

    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
}
