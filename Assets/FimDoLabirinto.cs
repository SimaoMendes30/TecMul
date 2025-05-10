using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDoLabirinto : MonoBehaviour
{
    public static string LastSceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LastSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("MenuFinal");
        }
    }
}
