using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Live : MonoBehaviour
{
    public GameObject[] hearts;
    public GameObject GameOverText;

    private int cont;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        cont = 0;
        GameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Title");
    }
    private void OnTriggerEnter(Collider other)
    {
        hearts[cont].SetActive(false);
        cont = cont + 1;

        if (cont >= 3)
        {
            //Time.timeScale = 0;
            GameOverText.SetActive(true);
            StartCoroutine(Wait());
        }
    }
}
