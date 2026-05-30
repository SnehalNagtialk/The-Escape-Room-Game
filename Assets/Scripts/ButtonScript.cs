using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class ButtonScript : MonoBehaviour
{
    public Slider VolumeSiledr;
    public AudioMixer Mixer;
    public void LoadScene1()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void SetVolume()
    {
        Mixer.SetFloat("volumebg",VolumeSiledr.value);
    }
}
