using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    

    public int quantArvores;
           
    void Start()
    {
        GameObject objEscolha = null;
        int escolha;
        

        for (int i = 0; i < quantArvores; i++)
        {
            
            escolha = Random.Range(0, 3);

            if (escolha == 0)
            {
              objEscolha = obj1;
               
            } else if (escolha == 1) 
            {

                objEscolha = obj2;

            }
            else if(escolha == 3)
            {

                objEscolha = obj2;

            }


            Vector3 randomPosition = new Vector3(Random.Range(16, -16), Random.Range(6, -6), 0);
          
            Instantiate(objEscolha, randomPosition,Quaternion.identity);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
