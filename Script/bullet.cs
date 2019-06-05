using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bullet : MonoBehaviour
{
    public Text scoretext;
    static int score = 0;
    void FixedUpdate(){
       
    }
    void OnCollisionEnter(Collision co) {
	if(co.gameObject.tag == "enemy"){
		Destroy(co.gameObject);
		/*Destroy(gameObject);*/
		score = score + 10;
        scoretext.text = "SCORE: " + score;
        if(score == 40){
            Destroy(gameObject);
            score = 0;
            SceneManager.LoadScene(1);
        }
	}
}
}
