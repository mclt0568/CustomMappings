﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMappings.MapObjects.Roads
{
	public class NormalRoads
	{
		string id;
		OtherObjects.TagContext context;
		int[] position = { 0, 0 };
		List<int[]> points = new List<int[]>();
		int width;
		
		public NormalRoads(string argId)
		{
			id = argId;
		}
	}
}
