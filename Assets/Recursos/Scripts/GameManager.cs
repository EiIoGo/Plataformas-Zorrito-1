using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject zorrito;
    public int score;
    public int health = 3;
    public AudioClip winSFX;
    public AudioClip loseSFX;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            LoadScene("Lost");
            SoundManager.instance.PlaySound(winSFX);
            score = 0;
            health = 3;
        }
        if (score >= 3)
        {
            LoadScene("Won");
            SoundManager.instance.PlaySound(loseSFX);
            score = 0;
            health = 3;
        }
    }

    void LoadScene(string name)
    {
        if (SceneManager.GetActiveScene().name != name)
        {
            SceneManager.LoadScene(name);
        }
    }
}
