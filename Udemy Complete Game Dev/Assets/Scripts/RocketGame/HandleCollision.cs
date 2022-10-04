using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleCollision : MonoBehaviour
{
    [SerializeField] float waitTime = 1;
    [SerializeField] AudioClip crashsound;
    [SerializeField] AudioClip victorysound;

    [SerializeField] ParticleSystem 

    AudioSource audiosource;

    bool isintransition = false;

    private void Start()
    {
        isintransition = false;
        audiosource = GetComponent<AudioSource>();
    }



    private void OnCollisionEnter(Collision other)
    {
        
        if (isintransition)
        {
            return;
        }
            switch (other.gameObject.tag)
            {
                case "friendly":
                    Debug.Log("that is a friendly");
                    break;

                case "finish":
                    Debug.Log("You finished the map!");
                    Victory();
                    break;

                default:
                    Debug.Log("You crashed");
                    Crash();
                    break;


            }
        
    }

    void Crash()
    {
        isintransition = true;
        audiosource.Stop();
        audiosource.PlayOneShot(crashsound);
        GetComponent<Movement>().enabled = false;
        Invoke(nameof(Reloadlevel), waitTime);
    }

    void Victory()
    {
        isintransition = true;
        audiosource.Stop();
        audiosource.PlayOneShot(victorysound);
        GetComponent<Movement>().enabled = false;
        Invoke(nameof(LoadNextLevel), waitTime);
    }


    void LoadNextLevel()
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex; // nykyisen scenen indeksi
        int nextsceneindex = currentsceneindex + 1;
        if (nextsceneindex == SceneManager.sceneCountInBuildSettings)
        {
            nextsceneindex = 0;
        }
        SceneManager.LoadScene(nextsceneindex);
    }
    void Reloadlevel()
    {
        int currentsceneindex = SceneManager.GetActiveScene().buildIndex; // nykyisen scenen indeksi
        SceneManager.LoadScene(currentsceneindex);
    }
}
