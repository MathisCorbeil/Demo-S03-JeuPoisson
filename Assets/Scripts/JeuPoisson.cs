using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JeuPoisson : MonoBehaviour
{
    float temps = 0f;
    public float poidsSaumon = 10.5f;
    [SerializeField] private float _poidsSardine = 100f;

    [SerializeReference] private GameObject _sardine;
    [SerializeReference] private GameObject _saumon;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(poidsSaumon);
        
    }

    public void Redemarrer(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {   
        temps += Time.deltaTime;
        Debug.Log(temps);

        Vector3 directionDeplacement = new Vector3(1f, 0f, 0f);
        //Debug.Log(poidsSaumon);
        _sardine.transform.position += directionDeplacement * 4f * Time.deltaTime;
    }

    public void ComparerPoissons()
    {
        if (poidsSaumon > _poidsSardine)
        {
            Debug.Log("Bon appetit!");
            _sardine.SetActive(false);
            //Destroy(_sardine);
        }
        else
        {
            Debug.Log("Non!");
        }
    }

}
