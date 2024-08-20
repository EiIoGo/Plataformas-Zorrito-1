using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] GameObject fxFeedback;
    public AudioClip gemSFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PickedUpBehavior();
        }
    }

    void PickedUpBehavior()
    {
        Destroy(gameObject);
        Instantiate(fxFeedback,gameObject.transform.position,Quaternion.identity);
        GameManager.instance.score += value;
        SoundManager.instance.PlaySound(gemSFX);
    }    
}
