﻿using System;

namespace IOTextFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			STable _STable = new STable ();
			IOSettings _io = new IOSettings (_STable); 

			Console.WriteLine (_STable.stable[0]);

			if (_io.open ()) {   //(_io.save ()) {
				Console.WriteLine ("Таблицата е прочетена успешно");
			} else {
				Console.WriteLine ("Таблицата НЕ е прочетена успешно");
			}
		}
	}
}
