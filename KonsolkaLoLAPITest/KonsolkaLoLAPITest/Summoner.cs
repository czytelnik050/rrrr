﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolkaLoLAPITest
{
	public class Summoner
	{
		public long id { get; set; }
		public string name { get; set; }
		public int profileIconId { get; set; }
		public long revisionDate { get; set; }
		public long summonerLevel { get; set; }
	}
}
