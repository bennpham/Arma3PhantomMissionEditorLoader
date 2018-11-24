using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Arma3PhantomMissionEditorLoader
{
	class Helper
	{
		// Answer received from https://stackoverflow.com/a/8022011/9463774
		/* Source Directory would be where the functions folders reside
		 * Destination Directory would be where your Arma 3 mission folder is */
		public static void copyDirectory(String sourceDir, String destinationDir)
		{
			// Assume source directory doesn't exist and create it
			System.IO.Directory.CreateDirectory(destinationDir);

			// Create subdirectory in destination
			foreach (String dir in System.IO.Directory.GetDirectories(sourceDir, "*", System.IO.SearchOption.AllDirectories))
			{
				System.IO.Directory.CreateDirectory(System.IO.Path.Combine(destinationDir, dir.Substring(sourceDir.Length + 1)));
			}

			// Copy each file through
			foreach (String fileName in System.IO.Directory.GetFiles(sourceDir, "*", System.IO.SearchOption.AllDirectories))
			{
				System.IO.File.Copy(fileName, System.IO.Path.Combine(destinationDir, fileName.Substring(sourceDir.Length + 1)));
			}
		}

		/* Check to make sure string is in hexidecimal format */
		public static bool isColorHexidecimal(String color)
		{
			Regex rx = new Regex("^#[a-fA-F0-9]{6}$");
			return rx.IsMatch(color);
		}

		// From https://stackoverflow.com/a/2395708/9463774
		/* Returns C# Color into hexidecimal string format */
		public static string hexConverter(System.Drawing.Color color)
		{
			return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}
	}
}
