using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{

    public int lives = 3;
    public Image [] livesUI;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.tag == "Enemy"){
            Destroy (collision.collider.gameObject);
            lives -=1;
            for(int i = 0; i < livesUI.Length; i++){
                if( i< lives){
                    livesUI[i].enabled = true;
                }
                else{
                    livesUI[i].enabled = false;
                }
            }
            if(lives <=0){
                Destroy(gameObject);
                ShowGameOver();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy Projectile"){
            Destroy (collision.gameObject);
            lives -=1;
            for(int i = 0; i < livesUI.Length; i++){
                if( i< lives){
                    livesUI[i].enabled = true;
                }
                else{
                    livesUI[i].enabled = false;
                }
            }
            if(lives <=0){
                Destroy(gameObject);
                ShowGameOver();
            }
        }
    }

    void ShowGameOver()
    {
        if(gameOverScreen != null)
        {
            gameOverScreen.SetActive(true); // Ativa a tela de Game Over
            Time.timeScale = 0f; // Pausa o jogo
        }
    }
}
