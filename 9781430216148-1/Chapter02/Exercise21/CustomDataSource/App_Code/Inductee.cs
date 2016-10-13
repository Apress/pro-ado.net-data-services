using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Services.Common;

[DataServiceKey("Name")]
public class Inductee
{
    public string Name { get; set; }
    public bool Group { get; set; }
    public int YearInducted { get; set; }
    public List<Song> Songs { get; set; }

    public static List<Inductee> MakeInducteeList()
    {
        return (new List<Inductee>()
        {
            new Inductee()
            {
                Name = "Rolling Stones",
                Group = false,
                YearInducted = 1990,
                Songs = new List<Song>()
            },
            new Inductee()
            {
                Name = "Beatles",
                Group = false,
                YearInducted = 1986,
                Songs = new List<Song>()
            }
        });
    }
}