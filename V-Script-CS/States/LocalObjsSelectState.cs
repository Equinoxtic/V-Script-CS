using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Script_CS.States
{
	class LocalObjsSelectState
	{
		public void LObjsSelection()
		{
			var curSelection = 0;

			LocalObjects.Sample lSample = new LocalObjects.Sample();

			Console.WriteLine("===== Object Selection =====\n");
			Console.Write("Select an Object:\n[1] Sample\n");
			curSelection = Convert.ToInt32(Console.ReadLine());

			switch (curSelection)
			{
				case 1:
					lSample.SetAttributes();
					break;
			}
		}
	}
}
