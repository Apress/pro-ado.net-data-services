using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Services.Common;

/// <summary>
/// Summary description for Song
/// </summary>
[DataServiceKey("SongTitle")]
public class Song
{
    public string SongTitle {get;set;}

    public static List<Song> MakeSongList()
    {
        return (new List<Song>()
        {
            new Song(){SongTitle="Satisfaction"},
            new Song(){SongTitle="All you need is love"},
        });
    }
}
