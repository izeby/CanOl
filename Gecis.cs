using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Gecis : MonoBehaviour
{
    // Start is called before the first frame update
 public void kisisel()
    {
        SceneManager.LoadScene("kisisel");
    }

    public void anamenu()
    {
        SceneManager.LoadScene("AnaMenu");
    }
    public void acil()
    {
        SceneManager.LoadScene("acilkan");
    }

    public void covid()
    {
        Application.OpenURL("https://covid19.saglik.gov.tr/");
    }
    public void nobetci()
    {
        Application.OpenURL("https://www.haberturk.com/nobetci-eczaneler");
    }
   
}
