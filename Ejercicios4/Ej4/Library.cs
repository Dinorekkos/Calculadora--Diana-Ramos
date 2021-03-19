using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MonoBehaviour
{
    public string newBookTitle;
    public string newBookAuthor;
    public int newBookNumberOfPages;
    public string newBookGenre;
    public int newBookPublishYear;
    public string newBookState;
    public string newBookColor;

    private int lengthLibrary;

    public GameObject buttonReplace;
    
    
    public int LengthLibrary
    {
        get {return lengthLibrary;}
        set{lengthLibrary = value;}
    }

    List <BooksAtributes> books = new List<BooksAtributes>();

    void Awake()
    {
        LengthLibrary = 3;
        Debug.Log("Espacios disponibles de libros " + LengthLibrary);
        buttonReplace.SetActive(false);
    }
     public void AddBookButton()
    {
        if(LengthLibrary > 0)
        {   
            AddBook();
        }

        if(LengthLibrary <= 0)
        {
            Debug.Log("Librería llena");
            buttonReplace.SetActive(true);
        }
        
    }

    void AddBook()
    {
        BooksAtributes newBook = new BooksAtributes("",0 ,"","");
        newBook.Title = newBookTitle;
        newBook.Author = newBookAuthor;
        newBook.NumberOfPages = newBookNumberOfPages;
        newBook.Genre = newBookGenre;
        newBook.PublishYear = newBookPublishYear;
        newBook.BooksState = newBookState;
        newBook.BookColor = newBookColor;
    
        books.Add(newBook);

        Debug.Log (newBook.BooksAtributesString(newBook)); 

        LengthLibrary --; 
        if(LengthLibrary < 0)
        {
            LengthLibrary ++;
        }
    }

    public void ShowBook()
    {   
       Debug.Log("Libros en librería: "+ books.Count);
       Debug.Log("Espacios restantes en librería:  "+ LengthLibrary);
    }     
    public void ReplaceBook()
    {   
         Debug.Log("Ingresa un nuevo libro"); 
        Debug.Log("Selecciona el que quieras reemplazar");             
    }   
    public void BookContainer1(int replaceBook)
    {   
        Debug.Log("Este es el libro: " + replaceBook);
        
        books.RemoveAt(replaceBook);
        AddBook();

    } 
   
}




