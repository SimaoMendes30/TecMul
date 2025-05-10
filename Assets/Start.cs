using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
    public void MudarCena()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
