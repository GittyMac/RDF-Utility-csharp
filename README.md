# RDF-Utility-csharp
A C# port of the RDF utility.

## EXE Usage
To use it, simply type ``RDFUtil.exe "PATH"`` in a command line, replacing PATH with the path to your RDF/XML file. It will create a converted file in the same directory, and can replace files that were previously there, so be careful.
You can also use "Open With" to make it convert RDF/XMLs when you double click or open the context menu.

## Developer Usage
To use it in any C# program, add the RDFTool.cs class to your project.
### Decoding
You will need to convert the RDF file into a byte array to decode, then call decode with an ISO_8859_1 version of your byte array. It will return a string of the output XML.
```csharp
Encoding iso_8859_1 = Encoding.GetEncoding("iso-8859-1");
byte[] RDFData = File.ReadAllBytes(file.rdf);
decodedrdf = RDFTool.decode(iso_8859_1.GetString(RDFData));
```

### Encoding
You will need to convert the XML file into a byte array to encode, then call encode with an ISO_8559_1 version of your XML data. It will return byte data of the output RDF.

```csharp
Encoding iso_8859_1 = Encoding.GetEncoding("iso-8859-1");
byte[] XMLData = iso_8859_1.GetBytes(output.ToString());
File.WriteAllBytes(file.rdf, iso_8859_1.GetBytes(RDFTool.encode(iso_8859_1.GetString(XMLData))));
```

For a real use of this class, check out the Program.cs file in this project.
