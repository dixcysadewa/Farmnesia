using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenu : MonoBehaviour
{
    public void KlikYa()
    {
        Debug.Log("Tombol YA diklik");
        Application.Quit();
    }

    public void KlikBatal()
    {
        Debug.Log("Tombol BATAL diklik");
        SceneManager.LoadScene("Exit");
    }
}