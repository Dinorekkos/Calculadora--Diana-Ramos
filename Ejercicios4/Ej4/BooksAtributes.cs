using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksAtributes : Book
{
 
 public Book bookClass = new Book ();

private string genre;
private int publishYear;
private string booksState;
private string bookColor;




public BooksAtributes (string aGenre, int aPublisYear, string aBookState, string aBookColor)    
{
    genre = aGenre;
    publishYear = aPublisYear;
    booksState = aBookState;
    bookColor = aBookColor;
}


public string Genre
{
    get {return genre;}
    set {genre = value;}
}

public int PublishYear
{
    get {return publishYear;}
    set {publishYear = value;}
}

public string BooksState 
{
    get {return booksState;}
    set {booksState = value;}
    
}

public string BookColor
{
    get {return bookColor;}
    set {bookColor = value;}
}

public string BooksAtributesString (BooksAtributes bookAtString)
{
    string tempo = bookAtString.Title.ToString() + " " + bookAtString.Author.ToString() + " " +  bookAtString.NumberOfPages.ToString() + bookAtString.Genre.ToString() + 
    " " + bookAtString.PublishYear.ToString() + " "+ bookAtString.BooksState.ToString() + " " + bookAtString.BookColor.ToString();

    return tempo;
}


}
