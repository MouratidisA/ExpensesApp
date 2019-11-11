using System;
using SQLite;

namespace ExpensesApp.models
{
    class Expense
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }
        [MaxLength(20)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

    }
}
