using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Services;

public class AssignInducteesToSongs
{
    public static void Assign(List<Inductee> inductee, List<Song> songs)
    {
        inductee[0].Songs.Add(songs[0]);
        inductee[1].Songs.Add(songs[1]);
    }
}
/// <summary>
/// Summary description for MyDataModel
/// </summary>
public class MyDataModel
{
    static List<Inductee> inductees;
    static List<Song> songs;

    static MyDataModel()
    {
        inductees = Inductee.MakeInducteeList();
        songs = Song.MakeSongList();
        AssignInducteesToSongs.Assign(inductees, songs);
    }

    public IQueryable<Inductee> Inductees
    {
        get
        {
            return inductees.AsQueryable();
        }
    }

    public IQueryable<Song> Songs
    {
        get
        {
            return songs.AsQueryable();
        }
    }
}


