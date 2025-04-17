# IniSharp

## Library for ini configuration file

**IniSharp** is a lightweight and easy-to-use C# library designed for managing INI configuration files. It provides a simple API to perform common operations such as reading values, writing updates, merge, import, compare, conversion to and from json\\xml format and checking the existence of specific sections, fields, and values within an INI file. 
Whether you're building desktop applications, utilities, or tools that rely on structured configuration files, **IniSharp** offers a reliable and efficient solution for handling INI-based settings.

---

## 🚀 Key Features

### 📖 Read INI Files  
Effortlessly parse `.ini` files and extract values from any section or field with minimal code.

### ✍️ Write & Update  
Modify existing values or add new sections and keys programmatically with precision and safety.

### 🔀 Merge Files  
Combine multiple INI files into a single unified configuration, resolving conflicts smoothly.

### 📥 Import INI Data  
Import configuration data from various sources and dynamically load it into your application.

### 🔄 Convert to/from JSON & XML  
Seamlessly convert INI data to and from **JSON** and **XML** formats for broader compatibility and easy integration.

### 🧭 Compare Files  
Identify differences between two INI files to track changes, detect overrides, or audit modifications.

### 🔍 Existence Checks  
Check if specific **sections**, **field**, or **values** exist—ideal for validation and conditional logic.

### 📤 Export  
Save and export modified configurations back to `.ini` format.

---

## In summary :

**IniSharp** combines the simplicity of INI with the flexibility of modern data handling. Whether you're a developer, system integrator, or DevOps engineer, IniSharp helps you manage your configuration files like a pro.


With **IniSharp**, you can streamline configuration management in your C# applications with clear, readable code and dependable performance.

---

### Note on naming convention :

The concept commonly used to define **keys** in this library and relative documentation is called **field**.

---

## Projects

IniSharp is a .NET library to manage ini configuration file and it's a part of a **Visual Studio 2022** solution containing others projects.
This repository contains following projects :
- IniSharp (.Net framework of library, now disabled)
- IniSharp.Test (.Net framework of test library, now disabled)
- IniSharpNet (.NET library)
- IniSharpNet.Test  (.NET test library)
- IniSharp.GUI (for GUI test of the .NET library, now disabled)

---
 
## Some usage

config.ini
```dosini
; questo è un commento
# anche questo è un commento
[SEZIONE_1]
campo001=valore1
Campo2=valore002

[SEZIONE_2]
Campo2=valore002
valoreacapo

campo4=

; commento
[SEZIONE_3]
[SEZIONE_4]
; commento
[SEZIONE_5]

campo6=000
```

C# code :

```cs
IniConfig config = new IniConfig();
IniSharp iniSharp = new IniSharp(fullPathFile,config);

// If fullPathFile is not null or empty and file exists then actual == True
Boolean actual = iniSharp.Read();

// output of next line is "SEZIONE_1"
Console.WriteLine(iniSharp.Section[0].Name);

// output of next line is "campo001"
Console.WriteLine(iniSharp.Section[0].Fields[0].Name);

// output of next line is "0"
Console.WriteLine(iniSharp.Section[2].Fields.Count);

// output of next line is "valore002"
Console.WriteLine(iniSharp.Section[1].Fields[0].Lines[0]);

// output of next line is "valoreacapo"
Console.WriteLine(iniSharp.Section[1].Fields[0].Lines[1]) 

```

Multiline value are separated by newline by default configuration provides by IniConfig config.


Multivalue can be also separated by "," or "|" char.


```dosini
Campo2=valore002,valoreacapo
```

```cs
// default value for MultiValueSeparator in config is NEWLINE
IniSharp iniSharp = new IniSharp(fullPathFile);
iniSharp.MultiValueSeparator = MULTIVALUESEPARATOR.COMMA;
```

or 

```dosini
Campo2=valore002|valoreacapo
```

```cs
IniSharp iniSharp = new IniSharp(fullPathFile);
iniSharp.MultiValueSeparator = MULTIVALUESEPARATOR.PIPE;
```

## Grammar tips

A section line (**[somesection]** ) must start with "**[**" (open square brackets) char and end with a "**]**" (close square brackets) char. Every char (except new line and any *trimmable* char according to C# rules) after "\]" will produce an unpreditable result, best case scenario return an error.

A field line ("fieldname=fieldcontent" ) must start with a char and end with new line, parser split line with "=" char and trim both content.



## Indexer 

Set new string throught indexer :
```cs
String newValue = "ThisIsANewValue";

// Get/Set indexed value, int and string
// Accessor for string name
iniSharp["SEZIONE_1"]["campo001"][0] = newValue;
// or
// Accessor for int index
iniSharp[0][0][0] = newValue;

```

Add a new value in next line :

```cs
String newValue = "ThisIsANewValue";

IniConfig config = new IniConfig();
config.MULTIVALUESEPARATOR = MULTIVALUESEPARATOR.PIPE;
// Accessor strategy for index
config.BYINDEX = AccessorsStatus.DINAMIC;
// Accessor strategy DYNAMIC for name (.BYNAME) is not used


// Get/Set indexed value, int and string
// lenght is 1 before set 
iniSharp["SEZIONE_1"]["campo001"][1] = newValue;
// now lenght is 2
```


## SetValue\\GetValue
```cs
// get value if exist , otherwise null
String newGetValue = iniSharpBegin.GetValue(0, 0, 0);
// Set
String newValue = "ThisIsANewValue";
Boolean bSuccess = iniSharpBegin.SetValue(0, 0, 0, newValue);
```
## Limits
- Do not accept char comment at the end of a field value like :
```dosini
FieldName=FieldValue001 ; SomeComment
``` 

"; SomeComment" will be part of field value
so use this way to comment a field :

```dosini
; SomeComment
FieldName=FieldValue001 
``` 

## Check

Check method return diffent (int) value according to status value

```cs
FileInfo fiInput = new FileInfo("<fullPathFileInputFile>");
IniConfig config = new IniConfig();
IniSharp iniSharp = new IniSharp(fiInput.FullName,config);
iniSharp.Read();

// -2 : section do not exist
// -1 : section exist , field do not exit
// 0  : section , field and index value exist
// +1 : section , field exist but indexvalue eccede by 1 of current Lines count
// +2 : section , field exist but indexvalue eccede by more than 1 of current Lines count

// check if section 0 , field 1 and fieldvalue with index 2 exists
if(iniSharp.Check(0,1,2) == 0)
{
	// ... do something ...
}

// or

if(iniSharp.Check("Section_1","Field_2","Value_3") == 0)
{
	// ... do something ...
}
```

## Merge\\Import

Merge method provide the ability to create a IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Import has the same goal by doing it's job in place.
```cs
IniConfig iniConfig = new IniConfig();

IniSharp first = new IniSharp(new FileInfo("<fullPathFileInputFile_first>"), iniConfig);
first.Read();
IniSharp second = new IniSharp(new FileInfo("<fullPathFileInputFile_second>"), iniConfig);
second.Read();

// duplicate section\field\value are not allowed
// in case two loaded ini file has different field value separator (alert : need 2 different IniConfig) , merged object inherided config from first object
IniSharp merged = IniSharp.Merge(first, second, false, false, false);
```
Import example :
```cs
IniConfig iniConfig = new IniConfig();

IniSharp first = new IniSharp(new FileInfo("<fullPathFileInputFile_first>"), iniConfig);
first.Read();
IniSharp second = new IniSharp(new FileInfo("<fullPathFileInputFile_second>"), iniConfig);
second.Read();
// Merged in place
first.Import(second, false, false, false);
```


## Conversion : to and from Json
IniSharp expose 2 different Json conversion , one custom (ToJson,FromJson) and the other through Newtonsoft serialization (ToJsonSerialize,FromJsonDeserialize). 

Ini file to ToJson
```cs
IniSharp iniSharpSerialize = new IniSharp(new FileInfo("<fullPathFileInputFile_first>"), new IniConfig());
iniSharpSerialize.Read();

// it manage as nested dictionary
string customtextjson = iniSharpSerialize.ToJson();

// using Newtonsoft.Json
string newtonsofttextjson = iniSharpSerialize.ToJsonSerialize();

//
IniSharp iniSharpDeserializeCustom = new IniSharp();
iniSharpDeserializeCustom.FromJson(customtextjson);

IniSharp iniSharpDeserializeNewtonsoft = new IniSharp();
iniSharpDeserializeNewtonsoft.FromJsonDeserialize(newtonsofttextjson);


// actual is True
Boolean actual =    IniSharp.AreEquals(iniSharpSerialize, iniSharpDeserializeCustom) &&
                    IniSharp.AreEquals(iniSharpSerialize, iniSharpDeserializeNewtonsoft) &&
                    IniSharp.AreEquals(iniSharpDeserializeCustom, iniSharpDeserializeNewtonsoft);
```
Serialization\\Deserialization are config agnostic, do not preserve field value separator. 
It's responsability of IniSharp object established which one impose.

## Conversion : to and from Xml
IniSharp expose xml conversion methods (ToXml,FromXml)
```cs
IniSharp iniSharp = new IniSharp(new FileInfo("<fullPathFileInputFile_first>"), new IniConfig());
iniSharp.Read();

string textxml = iniSharp.ToXml();

IniSharp deserialize = new IniSharp();

deserialize.FromXml(textxml);

// actual is True
Boolean actual = IniSharp.AreEquals(iniSharp, deserialize);

```
## Equals
IniSharp expose <b>public static bool AreEquals(IniSharp first, IniSharp second)</b> method and a <b>public bool Equals(IniSharp other)</b>.
Comparison is computated by sorted entity string of two object.

Comparison are config agnostic.

## Read\\Write
```cs
FileInfo fiInput = new FileInfo("<fullPathFileInputFile>");
IniConfig config = new IniConfig();
IniSharp iniSharp = new IniSharp(fiInput.FullName,config);
iniSharp.Read();

// ... change something ...

FileInfo fiOutput = new FileInfo("<fullPathFileOutputFile>");
iniSharp.Write(fiOutput);
```

## Tech

Here some useful link:

- [Wikipedia] - Wikipedia page for Ini file
- [Fileformat] - Fileformat page for Ini file
- [C#indexer] - How to use CSharp indexer
- [Newtonsoft] - Newtonsoft : Popular high-performance JSON framework for .NET
- [Newtonsoft example] - Newtonsoft : Serializing and Deserializing JSON example

## License

MIT

**Free Software, Hell Yeah!**

## Date

15 apr 2025



[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

   [Wikipedia]: <https://en.wikipedia.org/wiki/INI_file>
   [Fileformat]: <https://docs.fileformat.com/system/ini/>
   [C#indexer]: <https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers>
   [Newtonsoft]: <https://www.newtonsoft.com/json>
   [Newtonsoft example]: <https://www.newtonsoft.com/json/help/html/serializingjson.htm>


