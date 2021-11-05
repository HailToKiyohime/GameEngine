using System.Collections;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LevelControl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
