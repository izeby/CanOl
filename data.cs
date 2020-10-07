using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class data : MonoBehaviour
{
    public InputField inputText;
    string tutorialText;
    public InputField inputText1;
    string tutorialText1;
    public InputField inputText2;
    string tutorialText2;
    public InputField inputText3;
    string tutorialText3;
    public InputField inputText4;
    string tutorialText4;
    public InputField inputText5;
    string tutorialText5;
    public InputField inputText6;
    string tutorialText6;
    public InputField inputText7;
    string tutorialText7;

    public void createTextAd()
    {
        string path = Application.dataPath + "/Log.txt";

        //if (!File.Exists(path))
        //{
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

    //}

    string content = "Kullanıcı Adı: " + inputText.text + "\n";
        File.AppendAllText(path, content);
    }
    public void createTextSoyad()
    {
        string path = Application.dataPath + "/Log.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

        }

        string content = "Kullanıcı Soyadı: " + inputText1.text + "\n";
        File.AppendAllText(path, content);
    }
    public void createTextYas()
    {
        string path = Application.dataPath + "/Log.txt";


        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

        }


        string content = "Kullanıcı Yaşı: " + inputText2.text + "\n";
        File.AppendAllText(path, content);
    }
    public void createTextKan()
    {
        string path = Application.dataPath + "/Log.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

        }



        string content = "Kullanıcı Kan Grubu: " + inputText3.text + "\n";
        File.AppendAllText(path, content);
    }
    public void createTextIl()
    {
        string path = Application.dataPath + "/Log.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

        }



        string content = "Kullanıcı İl: " + inputText4.text + "\n";
        File.AppendAllText(path, content);
    }
    public void createTextIlce()
    {
        string path = Application.dataPath + "/Log.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

        }



        string content = "Kullanıcı İlçe: " + inputText5.text + "\n";
        File.AppendAllText(path, content);
    }
    public void createTextMahalle()
    {
        string path = Application.dataPath + "/Log.txt";


        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

        }



        string content = "Kullanıcı Mahalle: " + inputText6.text + "\n";
        File.AppendAllText(path, content);
    }
    public void createTextCep()
    {
        string path = Application.dataPath + "/Log.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Kullanıcı Bilgileri \n\n");

        }



        string content = "Kullanıcı Telefon: " + inputText7.text + "\n";
        File.AppendAllText(path, content);
    }
    void Start()
    {

       
        tutorialText = PlayerPrefs.GetString("tutorialTextKeyName");
        inputText.text = tutorialText;
        createTextAd();


        tutorialText1 = PlayerPrefs.GetString("tutorialTextKeyName1");
        inputText1.text = tutorialText1;
        createTextSoyad();

        tutorialText2 = PlayerPrefs.GetString("tutorialTextKeyName2");
        inputText2.text = tutorialText2;
        createTextYas();

        tutorialText3 = PlayerPrefs.GetString("tutorialTextKeyName3");
        inputText3.text = tutorialText3;
        createTextKan();

        tutorialText4 = PlayerPrefs.GetString("tutorialTextKeyName4");
        inputText4.text = tutorialText4;
        createTextIl();
        tutorialText5 = PlayerPrefs.GetString("tutorialTextKeyName5");
        inputText5.text = tutorialText5;
        createTextIlce();
        tutorialText6 = PlayerPrefs.GetString("tutorialTextKeyName6");
        inputText6.text = tutorialText6;
        createTextMahalle();
        tutorialText7 = PlayerPrefs.GetString("tutorialTextKeyName7");
        inputText7.text = tutorialText7;
        createTextCep();

    }

    public void SaveThis()
    {
        tutorialText = inputText.text;
        PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);

    }
    public void SaveThis1()
    {
        tutorialText1 = inputText1.text;
        PlayerPrefs.SetString("tutorialTextKeyName1", tutorialText1);

    }
    public void SaveThis2()
    {
        tutorialText2 = inputText2.text;
        PlayerPrefs.SetString("tutorialTextKeyName2", tutorialText2);

    }
    public void SaveThis3()
    {
        tutorialText3 = inputText3.text;
        PlayerPrefs.SetString("tutorialTextKeyName3", tutorialText3);

    }
    public void SaveThis4()
    {
        tutorialText4 = inputText4.text;
        PlayerPrefs.SetString("tutorialTextKeyName4", tutorialText4);

    }
    public void SaveThis5()
    {
        tutorialText5 = inputText5.text;
        PlayerPrefs.SetString("tutorialTextKeyName5", tutorialText5);

    }
    public void SaveThis6()
    {
        tutorialText6 = inputText6.text;
        PlayerPrefs.SetString("tutorialTextKeyName6", tutorialText6);

    }
    public void SaveThis7()
    {
        tutorialText7 = inputText7.text;
        PlayerPrefs.SetString("tutorialTextKeyName7", tutorialText7);

    }

}
