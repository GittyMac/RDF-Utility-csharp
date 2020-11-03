using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RDFUtilCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			//
			//Init
			//
			RDFTool RDFTool = new RDFTool();
			string FileLoc = args[0];
			Encoding iso_8859_1 = Encoding.GetEncoding("iso-8859-1");
			byte[] RDFData = File.ReadAllBytes(FileLoc);
			string RDFConverted;

			//
			//Intro
			//
			Console.WriteLine("RDF Conversion Utility (C#)");
			Console.WriteLine("Original Program by WeNeedCoffee");
			Console.WriteLine("Ported by Lako");

			//
			//Conversion
			//
			if (File.Exists(FileLoc))
			{
				if (FileLoc.Contains(".rdf"))
				{
					RDFConverted = RDFTool.decode(iso_8859_1.GetString(RDFData));
					File.WriteAllText(FileLoc.Replace(".rdf", ".xml"), RDFConverted);
					Console.WriteLine("RDF successfully converted!");
				}
				else if (FileLoc.Contains(".xml"))
				{
					RDFConverted = RDFTool.encode(iso_8859_1.GetString(RDFData));
					File.WriteAllBytes(FileLoc.Replace(".xml", ".rdf"), iso_8859_1.GetBytes(RDFConverted));
					Console.WriteLine("XML successfully converted!");
				}
			}
			else Console.WriteLine("File does not exist!");
		}


	}
}
