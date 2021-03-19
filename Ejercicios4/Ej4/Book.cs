using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Book 
{
    private string title;
    private string author;
    private int numberOfPages;

    public Book()
    {
    }
 
    public string Title
    {
        get {return title;}
        set {title = value;}
    }

    public string Author
    {
        get{return author;}
        set {author = value;}
    }

    public int NumberOfPages 
    {
        get {return numberOfPages;}
        set {numberOfPages = value;}
    }




}
