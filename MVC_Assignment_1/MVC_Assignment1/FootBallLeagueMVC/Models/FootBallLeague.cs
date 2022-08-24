using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootBallLeagueMVC.Models
{
    public class FootBallLeague
    {
        [Key]
        [Required(ErrorMessage ="Please Enter MatchID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchID { get; set; }

        [Required(ErrorMessage = "Please Enter MatchID")]
        [Column("TeamName1")]
        public string TeamName1 { get; set; }

        [Required(ErrorMessage = "Please Enter MatchID")]
        [Column("TeamName2")]
        public string TeamName2 { get; set; }

        [Required(ErrorMessage = "Please Enter MatchID")]
        [Column("Status")]
        public string Status { get; set; }

        [Column("WinningTeam")]
        public string WinningTeam { get; set; }

        [Required(ErrorMessage = "Please Enter MatchID")]
        [Column("Points")]
        public int Points { get; set; }
    }
}