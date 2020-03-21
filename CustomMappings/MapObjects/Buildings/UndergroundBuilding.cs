using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMappings.MapObjects.Buildings
{
	public class UndergroundBuildings
	{
		string id;
		dynamic mark;
		OtherObjects.TagContext context;
		int[] position = { 0, 0 };
		public UndergroundBuildings(string argId) {
			id = argId;
		}
	}
}
