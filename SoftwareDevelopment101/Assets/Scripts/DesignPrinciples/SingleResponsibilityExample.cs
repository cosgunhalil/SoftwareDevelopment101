using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using UnityEngine;

namespace SD101.Example.SingleResponsibility
{
    public class SingleResponsibilityExample : IExample
    {
        public void Execute()
        {
            Book book = new Book();
            BookLocationService bookLocationService = new BookLocationService();

            Debug.Log(bookLocationService.GetBookLocation(book).GetLocation().x);

        }
    }

    //bir class'ın değişmek için tek ama tek bir sebebi olmalı!
    public class Book
    {
        private string name;
        private int totalPageCount;

        public string GetName()
        {
            return name;
        }

        public int GetTotalPageCount()
        {
            return totalPageCount;
        }
    }

    public class BookLocation
    {
        private Vector2 location;

        public BookLocation(Vector2 location)
        {
            this.location = location;
        }

        public Vector2 GetLocation()
        {
            return location;
        }
    }

    public class BookLocationService
    {
        List<Book> books = new List<Book>();

        public BookLocation GetBookLocation(Book book)
        {
            //todo write find book method
            return new BookLocation(new Vector2(0,1));
        }
    }
}


