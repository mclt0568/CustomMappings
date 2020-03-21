using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomMappings.MapObjects;

namespace CustomMappings.MapObjects.Buildings
{
	public class NormalBuildings
	{
		string id;
		dynamic mark;
		OtherObjects.TagContext context;
		int[] position = {0,0};
		
		public NormalBuildings(string argId) {
			id = argId;
		}
	}
}
