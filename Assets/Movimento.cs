using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimento : MonoBehaviour
{
    public float movimento;
    Rigidbody corpo;
    public float xInput;
    public float zInput;

    void Start()
    {
        corpo = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
        corpo.AddForce(xInput * movimento, 0, zInput * movimento);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
