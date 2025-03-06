# IniSharp
## Library for ini configuration file

IniSharp is a .NET library to manage ini configuration file.
This repository contains following projects :
- IniSharp (.Net framework of library , now not completed tested)
- IniSharp.Test (.Net framework of test library , now not completed tested)
- IniSharpNet (.NET library)
- IniSharpNet.Test  (.NET test library)
- IniSharp.GUI (for GUI test of the .NET library)
 
Usage :

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
// Accessor strategy DYNAMIC for name is not used


// Get/Set indexed value, int and string
// lenght is 1 before set 
iniSharp["SEZIONE_1"]["campo001"][1] = newValue;
// now lenght is 2
```


## SetValue\GetValue
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

## Load\Write
```cs
IniSharp iniSharp = new IniSharp(fi.FullName,config);
iniSharp.Config =  config;
iniSharp.Read();
```			

## Tech

Here some useful link:

- [Wikipedia] - Wikipedia page for Ini file
- [Fileformat] - Fileformat page for Ini file
- [C#indexer] - How to use CSharp indexer

## License

MIT

**Free Software, Hell Yeah!**

## Date

24 feb 2025



[//]: # (These are reference links used in the body of this note and get stripped out when the markdown processor does its job. There is no need to format nicely because it shouldn't be seen. Thanks SO - http://stackoverflow.com/questions/4823468/store-comments-in-markdown-syntax)

   [Wikipedia]: <https://en.wikipedia.org/wiki/INI_file>
   [Fileformat]: <https://docs.fileformat.com/system/ini/>
   [C#indexer]: <https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers>

