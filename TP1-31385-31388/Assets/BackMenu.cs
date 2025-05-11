using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void VoltarAoMenu()
    {
        SceneManager.LoadScene("MenuInicial"); 
    }
}
