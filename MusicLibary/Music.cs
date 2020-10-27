using System;
using System.Collections.Generic;
using System.Text;

namespace MusicLibary
{
   public class Music
   {
       private int _id;
       private string _titel;
       private string _artis;
       private int _duration;
       private int _publication;

       public Music()
       {
       }

       public Music(int id, string titel, string artis, int duration, int publication)
       {
           _id = id;
           _titel = titel;
           _artis = artis;
           _duration = duration;
           _publication = publication;
       }

       public int Id
       {
           get => _id;
           set => _id = value;
       }

       public string Titel
       {
           get => _titel;
           set => _titel = value;
       }

       public string Artis
       {
           get => _artis;
           set => _artis = value;
       }

       public int Duration
       {
           get => _duration;
           set => _duration = value;
       }

       public int Publication
       {
           get => _publication;
           set => _publication = value;
       }

       public override string ToString()
       {
           return $"{nameof(Id)}: {Id}, {nameof(Titel)}: {Titel}, {nameof(Artis)}: {Artis}, {nameof(Duration)}: {Duration}, {nameof(Publication)}: {Publication}";
       }
   }
}
