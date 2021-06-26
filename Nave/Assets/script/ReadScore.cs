//le o escore do arquivo e printa
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ReadScore : MonoBehaviour
{
    private string text = "Score\n";
    private List<int> score_list = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        ReadText();
        PrintText();
    }

    private void PrintText()
    {
        GetComponent<Text>().text = this.text;
    }

    private void ReadText()
    {
        string path = Directory.GetCurrentDirectory();
        string line;
        int aux;
      
        try
        {
            path += "\\Assets\\Score\\Score.txt";
            StreamReader sr = new StreamReader(path);
            line = sr.ReadLine();
            aux = int.Parse(line);
           
            while(line != null)
            {

                //this.text += line + "\n";
                score_list.Add(int.Parse(line)); 
                line = sr.ReadLine();
               
            }
            sr.Close();
            //ordena menor para maior
            score_list.Sort(delegate (int item, int item2)
            {
                return item.CompareTo(item2);
            });
            //reverte ficando do maior para o menor
            score_list.Reverse();
            //adiciona ao texto os elementos
            score_list.ForEach(delegate (int element)
            {
                this.text += element.ToString() + "\n";
            });
                
            
        }
        catch (System.Exception e)
        {

            Debug.Log(e.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
