//programa que gera um arquivo de texto para salvar o score do usuario
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private string score;
   
    public int SaveScore()
    {
        int aux  = -2;
        string path = "";

            var text = GameObject.FindGameObjectsWithTag("Score");
            foreach (var item in text)
            {
                Text point = item.GetComponent<Text>();
                this.score = point.text;
            }
            path = Directory.GetCurrentDirectory();
            path += "\\Assets\\Score\\Score.txt";
            if(File.Exists(path))
            {
                try
                {

                    
                //grava se não contem
                    if(ReadScore(path) == 0 )
                    {
                        StreamWriter sw = new StreamWriter(path, append: true);
                        sw.WriteLine(this.score);
                        sw.Close();
                        aux = 0;

                    }
                    else
                    {
                        aux = -1;
                    }
                }
                catch (System.Exception e)
                {

                    Debug.Log(e.Message);
                    aux = -2;
                }
        }
        else
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(this.score);
            sw.Close();
            aux = 0;
        }
        return aux;
    }
    //se tiver igual não faz nada se tiver diferente salva
    private int ReadScore(string path)
    {
        int aux;
        string line;
        List<string> string_list = new List<string>();
        try
        {
            StreamReader sr = new StreamReader(path);
            
            line = sr.ReadLine();
            while(line != null)
            {
                string_list.Add(line);
                line = sr.ReadLine();

            }
            sr.Close();
            if (string_list.Contains(this.score))
            {
                aux = -1;
            }
            else
            {
                aux = 0;
            }

            
            
        }
        catch (System.Exception e )
        {
            Debug.Log(e.Message);
            aux = 2;
        }
        return aux;
    }
    
}
