using System;
using System.Collections.Generic;

namespace Lab00ObjectsAndClasses
{
	class Song
	{
		public string TypeList { get; set; }
		public string Name { get; set; }
		public string Time { get; set; }
	}
	class SongList
	{
		public int Number { get; set; }
		public List<Song> Songs { get; set; }
		public SongList()
		{
			Songs = new List<Song>();
			Number = 0;
		}
			
		public void Run()
		{
			int Number = int.Parse(Console.ReadLine());

			for (int i = 0; i < Number; i++)
			{
				string[] raw = Console.ReadLine().Split('_');
				AddSong(raw);
			}

			string typeList = Console.ReadLine();
			DisplaySongListType(typeList);
		}
		public void AddSong(string[] raw)
		{
			string type = raw[0];
			string name = raw[1];
			string time = raw[2];

			Song song = new Song
			{
				TypeList = type,
				Name = name,
				Time = time
			};
			Songs.Add(song);
		}
		public void DisplaySongListType(string typeList)
		{
			if (typeList == "all")
			{
				foreach (var song in Songs)
				{
					Console.WriteLine(song.Name);
				}
			}
			else
			{
				foreach (var song in Songs)
				{
					if (song.TypeList == typeList)
						Console.WriteLine(song.Name);
				}
			}
		}
	}
}
