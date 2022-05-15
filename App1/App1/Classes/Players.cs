using System;
using SQLite;

namespace App1.Classes
{
    [Table("Player")]
    public class Player
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string pName1 { get; set; }
        public string pScore1 { get; set; }

        public string pName2 { get; set; }
        public string pScore2 { get; set; }

        public string pName3 { get; set; }
        public string pScore3 { get; set; }

        public string pName4 { get; set; }
        public string pScore4 { get; set; }

        public string pName5 { get; set; }
        public string pScore5 { get; set; }

        public string pName6 { get; set; }
        public string pScore6 { get; set; }

    }
    [Table("Score")]
    public class Score
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string score1 { get; set; }
        public string score2 { get; set; }
        public string score3 { get; set; }
        public string score4 { get; set; }
        public string score5 { get; set; }
        public string score6 { get; set; }


    }
}