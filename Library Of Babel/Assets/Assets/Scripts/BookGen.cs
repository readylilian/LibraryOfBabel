using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookGen : MonoBehaviour
{
    int pgNum = 410;
    int charCap = 80;
    int lineCap = 40;
    char[] bank = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',' ', ',','.'};
    [SerializeField]
    Text pageA;
    [SerializeField]
    Text pageB;
    List<string> book = new List<string>();
    // Start is called before the first frame update
    public List<string> GetBook()
    {
        int pageCharCap = charCap * lineCap;
        string thisPage = "";
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 40; j++)
            {
                for(int k = 0; k < 80; k++)
                {
                    thisPage += RandChar();
                }
                thisPage += "\n";
            }
            Debug.Log(thisPage);
            book.Add(thisPage);
        }
        return book;
    }
    char RandChar()
    {
        return bank[Random.Range(0,28)];
    }
}
