using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public Text hptext;
    
    int hp = 10;
   
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "enemy"){
            hp = hp - 1;
        
            hptext.text = "HP: " + hp;
        if(hp <= 0){
            Destroy(gameObject);
            hp = 10;
            SceneManager.LoadScene(0);
        }
        }
    }
}

