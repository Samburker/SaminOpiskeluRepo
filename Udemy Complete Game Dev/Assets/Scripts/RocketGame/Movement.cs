using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    AudioSource audioSource;
    [SerializeField] AudioClip mainEngine;
    [SerializeField] private float thrustAmount = 1;
    [SerializeField] private float rotateAmount = 1;

    [SerializeField] ParticleSystem leftthrusterparticles;
    [SerializeField] ParticleSystem rightthrusterparticles;
    [SerializeField] ParticleSystem mainthrusterparticles;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }


    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartThrusting();

        }
        else
        {
            StopThrusting();
        }

    }

    private void StartThrusting()
    {
        // tämän voisi tehdä myös rb.AddRelativeForce(0,1,0);
        rb.AddRelativeForce(Vector3.up * thrustAmount * Time.deltaTime);


        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(mainEngine);
        }

        if (!mainthrusterparticles.isPlaying)
        {
            mainthrusterparticles.Play();
        }
    }

    private void StopThrusting()
    {
        audioSource.Stop();
        mainthrusterparticles.Stop();
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotateleft();
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotateright();

        }
        else
        {
            Stoprotating();
        }

    }

    private void Stoprotating()
    {
        rightthrusterparticles.Stop();
        leftthrusterparticles.Stop();
    }

    private void Rotateright()
    {
        Rotation(-rotateAmount);
        if (!leftthrusterparticles.isPlaying)
        {
            leftthrusterparticles.Play();
        }
    }

    private void Rotateleft()
    {
        Rotation(rotateAmount);
        if (!rightthrusterparticles.isPlaying)
        {
            rightthrusterparticles.Play();
        }
    }

    // thrustAmount muuttujan sisältö laitetaan nyt rotationThisFrame muuttujaan
    void Rotation(float rotationThisFrame)
    {
        
        rb.freezeRotation = true; // freeze rotation so we can manual rotate
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationThisFrame);
    }
}
