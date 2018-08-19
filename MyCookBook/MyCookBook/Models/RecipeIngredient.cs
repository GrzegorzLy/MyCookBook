using MyCookBook.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCookBook.Models
{
    public class ReciptIngredient : ISqlModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double Quantity { get; set; }
        public Igredient Igredient { get; set; }

    }
}
