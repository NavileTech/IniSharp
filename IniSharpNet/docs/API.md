<a name='assembly'></a>
# IniSharpNet

## Contents

- [AccessorsStrategy](#T-IniSharpBox-AccessorsStrategy 'IniSharpBox.AccessorsStrategy')
  - [DINAMIC](#F-IniSharpBox-AccessorsStrategy-DINAMIC 'IniSharpBox.AccessorsStrategy.DINAMIC')
  - [NOT_INITIALIZE](#F-IniSharpBox-AccessorsStrategy-NOT_INITIALIZE 'IniSharpBox.AccessorsStrategy.NOT_INITIALIZE')
  - [STATIC](#F-IniSharpBox-AccessorsStrategy-STATIC 'IniSharpBox.AccessorsStrategy.STATIC')
- [ERROR](#T-IniSharpBox-ERROR 'IniSharpBox.ERROR')
  - [NOT_EXECUTE](#F-IniSharpBox-ERROR-NOT_EXECUTE 'IniSharpBox.ERROR.NOT_EXECUTE')
  - [NO_ERROR](#F-IniSharpBox-ERROR-NO_ERROR 'IniSharpBox.ERROR.NO_ERROR')
- [Field](#T-IniSharpBox-Field 'IniSharpBox.Field')
  - [#ctor(id,config)](#M-IniSharpBox-Field-#ctor-System-Int32,IniSharpBox-IniConfig- 'IniSharpBox.Field.#ctor(System.Int32,IniSharpBox.IniConfig)')
  - [#ctor(id,name,config)](#M-IniSharpBox-Field-#ctor-System-Int32,System-String,IniSharpBox-IniConfig- 'IniSharpBox.Field.#ctor(System.Int32,System.String,IniSharpBox.IniConfig)')
  - [#ctor()](#M-IniSharpBox-Field-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.Field.#ctor(IniSharpBox.IniConfig)')
  - [#ctor()](#M-IniSharpBox-Field-#ctor 'IniSharpBox.Field.#ctor')
  - [DefaultValue](#P-IniSharpBox-Field-DefaultValue 'IniSharpBox.Field.DefaultValue')
  - [Item](#P-IniSharpBox-Field-Item-System-Int32- 'IniSharpBox.Field.Item(System.Int32)')
  - [Lines](#P-IniSharpBox-Field-Lines 'IniSharpBox.Field.Lines')
  - [AccessorGet(index,status)](#M-IniSharpBox-Field-AccessorGet-System-Int32,IniSharpBox-AccessorsStrategy- 'IniSharpBox.Field.AccessorGet(System.Int32,IniSharpBox.AccessorsStrategy)')
  - [AccessorSet(value,index,status)](#M-IniSharpBox-Field-AccessorSet-System-String,System-Int32,IniSharpBox-AccessorsStrategy- 'IniSharpBox.Field.AccessorSet(System.String,System.Int32,IniSharpBox.AccessorsStrategy)')
  - [Add(lines)](#M-IniSharpBox-Field-Add-System-Collections-Generic-List{System-String}- 'IniSharpBox.Field.Add(System.Collections.Generic.List{System.String})')
  - [Add(lines)](#M-IniSharpBox-Field-Add-System-String[]- 'IniSharpBox.Field.Add(System.String[])')
  - [Add(line)](#M-IniSharpBox-Field-Add-System-String- 'IniSharpBox.Field.Add(System.String)')
  - [Replace(line)](#M-IniSharpBox-Field-Replace-System-String- 'IniSharpBox.Field.Replace(System.String)')
  - [Replace(lines)](#M-IniSharpBox-Field-Replace-System-Collections-Generic-List{System-String}- 'IniSharpBox.Field.Replace(System.Collections.Generic.List{System.String})')
  - [Replace(lines)](#M-IniSharpBox-Field-Replace-System-String[]- 'IniSharpBox.Field.Replace(System.String[])')
  - [Write()](#M-IniSharpBox-Field-Write 'IniSharpBox.Field.Write')
- [Fields](#T-IniSharpBox-Fields 'IniSharpBox.Fields')
  - [#ctor()](#M-IniSharpBox-Fields-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.Fields.#ctor(IniSharpBox.IniConfig)')
  - [Count](#P-IniSharpBox-Fields-Count 'IniSharpBox.Fields.Count')
  - [Field](#P-IniSharpBox-Fields-Field 'IniSharpBox.Fields.Field')
  - [Item](#P-IniSharpBox-Fields-Item-System-Int32- 'IniSharpBox.Fields.Item(System.Int32)')
  - [Item](#P-IniSharpBox-Fields-Item-System-String- 'IniSharpBox.Fields.Item(System.String)')
  - [Add(item)](#M-IniSharpBox-Fields-Add-IniSharpBox-Field- 'IniSharpBox.Fields.Add(IniSharpBox.Field)')
  - [Contains(item)](#M-IniSharpBox-Fields-Contains-IniSharpBox-Field- 'IniSharpBox.Fields.Contains(IniSharpBox.Field)')
  - [Contains(name)](#M-IniSharpBox-Fields-Contains-System-String- 'IniSharpBox.Fields.Contains(System.String)')
  - [Contains(index)](#M-IniSharpBox-Fields-Contains-System-Int32- 'IniSharpBox.Fields.Contains(System.Int32)')
  - [GetByName(name)](#M-IniSharpBox-Fields-GetByName-System-String- 'IniSharpBox.Fields.GetByName(System.String)')
  - [Write()](#M-IniSharpBox-Fields-Write 'IniSharpBox.Fields.Write')
- [Helpers](#T-IniSharpNet-Helpers 'IniSharpNet.Helpers')
  - [MULTIVALUESEPARATORs](#P-IniSharpNet-Helpers-MULTIVALUESEPARATORs 'IniSharpNet.Helpers.MULTIVALUESEPARATORs')
- [IniBase](#T-IniSharpBox-IniBase 'IniSharpBox.IniBase')
  - [_Config](#F-IniSharpBox-IniBase-_Config 'IniSharpBox.IniBase._Config')
  - [Config](#P-IniSharpBox-IniBase-Config 'IniSharpBox.IniBase.Config')
  - [ID](#P-IniSharpBox-IniBase-ID 'IniSharpBox.IniBase.ID')
  - [NetxId()](#M-IniSharpBox-IniBase-NetxId 'IniSharpBox.IniBase.NetxId')
- [IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig')
  - [#ctor()](#M-IniSharpBox-IniConfig-#ctor 'IniSharpBox.IniConfig.#ctor')
  - [#ctor(mULTIVALUESEPARATOR,indexstatus,namestatus)](#M-IniSharpBox-IniConfig-#ctor-IniSharpBox-MULTIVALUESEPARATOR,IniSharpBox-AccessorsStrategy,IniSharpBox-AccessorsStrategy- 'IniSharpBox.IniConfig.#ctor(IniSharpBox.MULTIVALUESEPARATOR,IniSharpBox.AccessorsStrategy,IniSharpBox.AccessorsStrategy)')
  - [_ArrMultiValueSeparator](#F-IniSharpBox-IniConfig-_ArrMultiValueSeparator 'IniSharpBox.IniConfig._ArrMultiValueSeparator')
  - [_MULTIVALUESEPARATOR](#F-IniSharpBox-IniConfig-_MULTIVALUESEPARATOR 'IniSharpBox.IniConfig._MULTIVALUESEPARATOR')
  - [ArrMultiValueSeparator](#P-IniSharpBox-IniConfig-ArrMultiValueSeparator 'IniSharpBox.IniConfig.ArrMultiValueSeparator')
  - [BYINDEX](#P-IniSharpBox-IniConfig-BYINDEX 'IniSharpBox.IniConfig.BYINDEX')
  - [BYNAME](#P-IniSharpBox-IniConfig-BYNAME 'IniSharpBox.IniConfig.BYNAME')
  - [MULTIVALUESEPARATOR](#P-IniSharpBox-IniConfig-MULTIVALUESEPARATOR 'IniSharpBox.IniConfig.MULTIVALUESEPARATOR')
- [IniItem](#T-IniSharpBox-IniItem 'IniSharpBox.IniItem')
  - [_Initialize](#F-IniSharpBox-IniItem-_Initialize 'IniSharpBox.IniItem._Initialize')
  - [Comments](#P-IniSharpBox-IniItem-Comments 'IniSharpBox.IniItem.Comments')
  - [Initialize](#P-IniSharpBox-IniItem-Initialize 'IniSharpBox.IniItem.Initialize')
  - [Name](#P-IniSharpBox-IniItem-Name 'IniSharpBox.IniItem.Name')
- [IniItemList](#T-IniSharpBox-IniItemList 'IniSharpBox.IniItemList')
  - [Contains(container,item)](#M-IniSharpBox-IniItemList-Contains-System-Collections-Generic-List{IniSharpBox-IniItem},IniSharpBox-IniItem- 'IniSharpBox.IniItemList.Contains(System.Collections.Generic.List{IniSharpBox.IniItem},IniSharpBox.IniItem)')
  - [Contains(container,name)](#M-IniSharpBox-IniItemList-Contains-System-Collections-Generic-List{IniSharpBox-IniItem},System-String- 'IniSharpBox.IniItemList.Contains(System.Collections.Generic.List{IniSharpBox.IniItem},System.String)')
  - [Contains(container,index)](#M-IniSharpBox-IniItemList-Contains-System-Collections-Generic-List{IniSharpBox-IniItem},System-Int32- 'IniSharpBox.IniItemList.Contains(System.Collections.Generic.List{IniSharpBox.IniItem},System.Int32)')
- [IniJsonInterop](#T-IniSharpNet-Conversion-IniJsonInterop 'IniSharpNet.Conversion.IniJsonInterop')
  - [GetIniAsJson(value,indented,preserveComments)](#M-IniSharpNet-Conversion-IniJsonInterop-GetIniAsJson-System-String,System-Boolean,System-Boolean- 'IniSharpNet.Conversion.IniJsonInterop.GetIniAsJson(System.String,System.Boolean,System.Boolean)')
  - [GetJsonAsIni(value,restoreComments)](#M-IniSharpNet-Conversion-IniJsonInterop-GetJsonAsIni-System-String,System-Boolean- 'IniSharpNet.Conversion.IniJsonInterop.GetJsonAsIni(System.String,System.Boolean)')
  - [JavaScriptEncode(value)](#M-IniSharpNet-Conversion-IniJsonInterop-JavaScriptEncode-System-String- 'IniSharpNet.Conversion.IniJsonInterop.JavaScriptEncode(System.String)')
- [IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp')
  - [#ctor(filename,config)](#M-IniSharpBox-IniSharp-#ctor-System-String,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.#ctor(System.String,IniSharpBox.IniConfig)')
  - [#ctor(filename)](#M-IniSharpBox-IniSharp-#ctor-System-String- 'IniSharpBox.IniSharp.#ctor(System.String)')
  - [#ctor(filename,config)](#M-IniSharpBox-IniSharp-#ctor-System-IO-FileInfo,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.#ctor(System.IO.FileInfo,IniSharpBox.IniConfig)')
  - [#ctor(filename)](#M-IniSharpBox-IniSharp-#ctor-System-IO-FileInfo- 'IniSharpBox.IniSharp.#ctor(System.IO.FileInfo)')
  - [#ctor(config)](#M-IniSharpBox-IniSharp-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.#ctor(IniSharpBox.IniConfig)')
  - [#ctor()](#M-IniSharpBox-IniSharp-#ctor 'IniSharpBox.IniSharp.#ctor')
  - [_Errors](#F-IniSharpBox-IniSharp-_Errors 'IniSharpBox.IniSharp._Errors')
  - [_Exceptions](#F-IniSharpBox-IniSharp-_Exceptions 'IniSharpBox.IniSharp._Exceptions')
  - [EnableDebug](#P-IniSharpBox-IniSharp-EnableDebug 'IniSharpBox.IniSharp.EnableDebug')
  - [Error](#P-IniSharpBox-IniSharp-Error 'IniSharpBox.IniSharp.Error')
  - [Errors](#P-IniSharpBox-IniSharp-Errors 'IniSharpBox.IniSharp.Errors')
  - [Exceptions](#P-IniSharpBox-IniSharp-Exceptions 'IniSharpBox.IniSharp.Exceptions')
  - [HasException](#P-IniSharpBox-IniSharp-HasException 'IniSharpBox.IniSharp.HasException')
  - [Item](#P-IniSharpBox-IniSharp-Item-System-Int32- 'IniSharpBox.IniSharp.Item(System.Int32)')
  - [Item](#P-IniSharpBox-IniSharp-Item-System-String- 'IniSharpBox.IniSharp.Item(System.String)')
  - [Sections](#P-IniSharpBox-IniSharp-Sections 'IniSharpBox.IniSharp.Sections')
  - [Success](#P-IniSharpBox-IniSharp-Success 'IniSharpBox.IniSharp.Success')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-Int32,System-Int32,System-Int32- 'IniSharpBox.IniSharp.Check(System.Int32,System.Int32,System.Int32)')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-Int32,System-String,System-Int32- 'IniSharpBox.IniSharp.Check(System.Int32,System.String,System.Int32)')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-String,System-Int32,System-Int32- 'IniSharpBox.IniSharp.Check(System.String,System.Int32,System.Int32)')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-String,System-String,System-Int32- 'IniSharpBox.IniSharp.Check(System.String,System.String,System.Int32)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-Int32,System-Int32,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.Int32,System.Int32,System.Int32)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-Int32,System-String,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.Int32,System.String,System.Int32)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-String,System-Int32,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.String,System.Int32,System.Int32)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-String,System-String,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.String,System.String,System.Int32)')
  - [Read(text)](#M-IniSharpBox-IniSharp-Read-System-String- 'IniSharpBox.IniSharp.Read(System.String)')
  - [Read(lines)](#M-IniSharpBox-IniSharp-Read-System-String[]- 'IniSharpBox.IniSharp.Read(System.String[])')
  - [Read()](#M-IniSharpBox-IniSharp-Read 'IniSharpBox.IniSharp.Read')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-Int32,System-Int32,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.Int32,System.Int32,System.Int32,System.String)')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-Int32,System-String,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.Int32,System.String,System.Int32,System.String)')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-String,System-Int32,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.String,System.Int32,System.Int32,System.String)')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-String,System-String,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.String,System.String,System.Int32,System.String)')
  - [Write(fi,overWrite)](#M-IniSharpBox-IniSharp-Write-System-IO-FileInfo,System-Boolean- 'IniSharpBox.IniSharp.Write(System.IO.FileInfo,System.Boolean)')
  - [_Constructor(filename,config)](#M-IniSharpBox-IniSharp-_Constructor-System-IO-FileInfo,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp._Constructor(System.IO.FileInfo,IniSharpBox.IniConfig)')
  - [_Read(lines)](#M-IniSharpBox-IniSharp-_Read-System-String[]- 'IniSharpBox.IniSharp._Read(System.String[])')
- [MULTIVALUESEPARATOR](#T-IniSharpBox-MULTIVALUESEPARATOR 'IniSharpBox.MULTIVALUESEPARATOR')
  - [COMMA](#F-IniSharpBox-MULTIVALUESEPARATOR-COMMA 'IniSharpBox.MULTIVALUESEPARATOR.COMMA')
  - [NEWLINE](#F-IniSharpBox-MULTIVALUESEPARATOR-NEWLINE 'IniSharpBox.MULTIVALUESEPARATOR.NEWLINE')
  - [PIPE](#F-IniSharpBox-MULTIVALUESEPARATOR-PIPE 'IniSharpBox.MULTIVALUESEPARATOR.PIPE')
- [PARSE_STATE](#T-IniSharpBox-PARSE_STATE 'IniSharpBox.PARSE_STATE')
  - [COMMENT](#F-IniSharpBox-PARSE_STATE-COMMENT 'IniSharpBox.PARSE_STATE.COMMENT')
  - [EMPTY_LINE](#F-IniSharpBox-PARSE_STATE-EMPTY_LINE 'IniSharpBox.PARSE_STATE.EMPTY_LINE')
  - [FIELD](#F-IniSharpBox-PARSE_STATE-FIELD 'IniSharpBox.PARSE_STATE.FIELD')
  - [INIT](#F-IniSharpBox-PARSE_STATE-INIT 'IniSharpBox.PARSE_STATE.INIT')
  - [SECTION](#F-IniSharpBox-PARSE_STATE-SECTION 'IniSharpBox.PARSE_STATE.SECTION')
- [Section](#T-IniSharpBox-Section 'IniSharpBox.Section')
  - [#ctor(id,config)](#M-IniSharpBox-Section-#ctor-System-Int32,IniSharpBox-IniConfig- 'IniSharpBox.Section.#ctor(System.Int32,IniSharpBox.IniConfig)')
  - [#ctor(id,name,config)](#M-IniSharpBox-Section-#ctor-System-Int32,System-String,IniSharpBox-IniConfig- 'IniSharpBox.Section.#ctor(System.Int32,System.String,IniSharpBox.IniConfig)')
  - [#ctor()](#M-IniSharpBox-Section-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.Section.#ctor(IniSharpBox.IniConfig)')
  - [Fields](#P-IniSharpBox-Section-Fields 'IniSharpBox.Section.Fields')
  - [Item](#P-IniSharpBox-Section-Item-System-Int32- 'IniSharpBox.Section.Item(System.Int32)')
  - [Item](#P-IniSharpBox-Section-Item-System-String- 'IniSharpBox.Section.Item(System.String)')
  - [Add(item)](#M-IniSharpBox-Section-Add-IniSharpBox-Field- 'IniSharpBox.Section.Add(IniSharpBox.Field)')
  - [Last()](#M-IniSharpBox-Section-Last 'IniSharpBox.Section.Last')
  - [Write()](#M-IniSharpBox-Section-Write 'IniSharpBox.Section.Write')
- [Sections](#T-IniSharpBox-Sections 'IniSharpBox.Sections')
  - [#ctor()](#M-IniSharpBox-Sections-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.Sections.#ctor(IniSharpBox.IniConfig)')
  - [Count](#P-IniSharpBox-Sections-Count 'IniSharpBox.Sections.Count')
  - [Item](#P-IniSharpBox-Sections-Item-System-Int32- 'IniSharpBox.Sections.Item(System.Int32)')
  - [Item](#P-IniSharpBox-Sections-Item-System-String- 'IniSharpBox.Sections.Item(System.String)')
  - [Section](#P-IniSharpBox-Sections-Section 'IniSharpBox.Sections.Section')
  - [Add(item)](#M-IniSharpBox-Sections-Add-IniSharpBox-Section- 'IniSharpBox.Sections.Add(IniSharpBox.Section)')
  - [Add(name)](#M-IniSharpBox-Sections-Add-System-String- 'IniSharpBox.Sections.Add(System.String)')
  - [Clear()](#M-IniSharpBox-Sections-Clear 'IniSharpBox.Sections.Clear')
  - [Contains(item)](#M-IniSharpBox-Sections-Contains-IniSharpBox-Section- 'IniSharpBox.Sections.Contains(IniSharpBox.Section)')
  - [Contains(name)](#M-IniSharpBox-Sections-Contains-System-String- 'IniSharpBox.Sections.Contains(System.String)')
  - [Contains(index)](#M-IniSharpBox-Sections-Contains-System-Int32- 'IniSharpBox.Sections.Contains(System.Int32)')
  - [GetByName(name)](#M-IniSharpBox-Sections-GetByName-System-String- 'IniSharpBox.Sections.GetByName(System.String)')
  - [Write()](#M-IniSharpBox-Sections-Write 'IniSharpBox.Sections.Write')

<a name='T-IniSharpBox-AccessorsStrategy'></a>
## AccessorsStrategy `type`

##### Namespace

IniSharpBox

##### Summary

Strategy for accessor property of indexer property used in parsing file

<a name='F-IniSharpBox-AccessorsStrategy-DINAMIC'></a>
### DINAMIC `constants`

##### Summary

Allow to add one value in Field at index == i+1 if i is actual max index of Field values
Valid only for BYINDEX accessor

<a name='F-IniSharpBox-AccessorsStrategy-NOT_INITIALIZE'></a>
### NOT_INITIALIZE `constants`

##### Summary

Strategy is not defined

<a name='F-IniSharpBox-AccessorsStrategy-STATIC'></a>
### STATIC `constants`

##### Summary

Do not allow to add item in field values

<a name='T-IniSharpBox-ERROR'></a>
## ERROR `type`

##### Namespace

IniSharpBox

##### Summary

Parsing errors

<a name='F-IniSharpBox-ERROR-NOT_EXECUTE'></a>
### NOT_EXECUTE `constants`

##### Summary

Parsing is not yet start

<a name='F-IniSharpBox-ERROR-NO_ERROR'></a>
### NO_ERROR `constants`

##### Summary

No error is detected

<a name='T-IniSharpBox-Field'></a>
## Field `type`

##### Namespace

IniSharpBox

##### Summary

Class for manage field in a ini file

<a name='M-IniSharpBox-Field-#ctor-System-Int32,IniSharpBox-IniConfig-'></a>
### #ctor(id,config) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-Field-#ctor-System-Int32,System-String,IniSharpBox-IniConfig-'></a>
### #ctor(id,name,config) `constructor`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-Field-#ctor-IniSharpBox-IniConfig-'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-IniSharpBox-Field-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='P-IniSharpBox-Field-DefaultValue'></a>
### DefaultValue `property`

##### Summary

Default value of the field , first element (return Lines[0])

<a name='P-IniSharpBox-Field-Item-System-Int32-'></a>
### Item `property`

##### Summary

Indexer declaration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-IniSharpBox-Field-Lines'></a>
### Lines `property`

##### Summary

Lines of a multiline field

<a name='M-IniSharpBox-Field-AccessorGet-System-Int32,IniSharpBox-AccessorsStrategy-'></a>
### AccessorGet(index,status) `method`

##### Summary

Get of indexer property

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| status | [IniSharpBox.AccessorsStrategy](#T-IniSharpBox-AccessorsStrategy 'IniSharpBox.AccessorsStrategy') |  |

<a name='M-IniSharpBox-Field-AccessorSet-System-String,System-Int32,IniSharpBox-AccessorsStrategy-'></a>
### AccessorSet(value,index,status) `method`

##### Summary

Set accessor of indexer property

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| status | [IniSharpBox.AccessorsStrategy](#T-IniSharpBox-AccessorsStrategy 'IniSharpBox.AccessorsStrategy') |  |

<a name='M-IniSharpBox-Field-Add-System-Collections-Generic-List{System-String}-'></a>
### Add(lines) `method`

##### Summary

Write a list of string in field

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

<a name='M-IniSharpBox-Field-Add-System-String[]-'></a>
### Add(lines) `method`

##### Summary

Write an array of string in field

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-IniSharpBox-Field-Add-System-String-'></a>
### Add(line) `method`

##### Summary

Write string in field

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| line | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Field-Replace-System-String-'></a>
### Replace(line) `method`

##### Summary

Clear and write string in field

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| line | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Field-Replace-System-Collections-Generic-List{System-String}-'></a>
### Replace(lines) `method`

##### Summary

Clear and write a list of string in field

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

<a name='M-IniSharpBox-Field-Replace-System-String[]-'></a>
### Replace(lines) `method`

##### Summary

Clear and write an array of string in field

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-IniSharpBox-Field-Write'></a>
### Write() `method`

##### Summary

Return field name/value + comments

##### Returns



##### Parameters

This method has no parameters.

<a name='T-IniSharpBox-Fields'></a>
## Fields `type`

##### Namespace

IniSharpBox

##### Summary

Class for manage a set of field in a section of a ini file

<a name='M-IniSharpBox-Fields-#ctor-IniSharpBox-IniConfig-'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='P-IniSharpBox-Fields-Count'></a>
### Count `property`

##### Summary

Return number of element of Field list

<a name='P-IniSharpBox-Fields-Field'></a>
### Field `property`

##### Summary

List of fields

<a name='P-IniSharpBox-Fields-Item-System-Int32-'></a>
### Item `property`

##### Summary

Indexer declaration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-IniSharpBox-Fields-Item-System-String-'></a>
### Item `property`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Fields-Add-IniSharpBox-Field-'></a>
### Add(item) `method`

##### Summary

Add item to Field list

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [IniSharpBox.Field](#T-IniSharpBox-Field 'IniSharpBox.Field') |  |

<a name='M-IniSharpBox-Fields-Contains-IniSharpBox-Field-'></a>
### Contains(item) `method`

##### Summary

Return true if item is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [IniSharpBox.Field](#T-IniSharpBox-Field 'IniSharpBox.Field') |  |

<a name='M-IniSharpBox-Fields-Contains-System-String-'></a>
### Contains(name) `method`

##### Summary

Return true if an item with Name == name is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Fields-Contains-System-Int32-'></a>
### Contains(index) `method`

##### Summary

Return true if an item with index is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-Fields-GetByName-System-String-'></a>
### GetByName(name) `method`

##### Summary

Return a field contained in Field list , otherwise return a new Field()

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Fields-Write'></a>
### Write() `method`

##### Summary

Return string used to write on file

##### Returns



##### Parameters

This method has no parameters.

<a name='T-IniSharpNet-Helpers'></a>
## Helpers `type`

##### Namespace

IniSharpNet

##### Summary

Helper class contains functions that help in assisting the library.

<a name='P-IniSharpNet-Helpers-MULTIVALUESEPARATORs'></a>
### MULTIVALUESEPARATORs `property`

##### Summary

Return a list of multi value separator enum

<a name='T-IniSharpBox-IniBase'></a>
## IniBase `type`

##### Namespace

IniSharpBox

##### Summary

Base class for core business application IniSharp

<a name='F-IniSharpBox-IniBase-_Config'></a>
### _Config `constants`

##### Summary

Protected field for configuration class

<a name='P-IniSharpBox-IniBase-Config'></a>
### Config `property`

##### Summary

Return configuration set of arguments

<a name='P-IniSharpBox-IniBase-ID'></a>
### ID `property`

##### Summary

Unique identifier for section or field

<a name='M-IniSharpBox-IniBase-NetxId'></a>
### NetxId() `method`

##### Summary

Return next id used for initialize list item in IniSharp like Section and Field

##### Returns



##### Parameters

This method has no parameters.

<a name='T-IniSharpBox-IniConfig'></a>
## IniConfig `type`

##### Namespace

IniSharpBox

##### Summary

Class devoted to store all configuration argument for parsing ini file

<a name='M-IniSharpBox-IniConfig-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='M-IniSharpBox-IniConfig-#ctor-IniSharpBox-MULTIVALUESEPARATOR,IniSharpBox-AccessorsStrategy,IniSharpBox-AccessorsStrategy-'></a>
### #ctor(mULTIVALUESEPARATOR,indexstatus,namestatus) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mULTIVALUESEPARATOR | [IniSharpBox.MULTIVALUESEPARATOR](#T-IniSharpBox-MULTIVALUESEPARATOR 'IniSharpBox.MULTIVALUESEPARATOR') |  |
| indexstatus | [IniSharpBox.AccessorsStrategy](#T-IniSharpBox-AccessorsStrategy 'IniSharpBox.AccessorsStrategy') |  |
| namestatus | [IniSharpBox.AccessorsStrategy](#T-IniSharpBox-AccessorsStrategy 'IniSharpBox.AccessorsStrategy') |  |

<a name='F-IniSharpBox-IniConfig-_ArrMultiValueSeparator'></a>
### _ArrMultiValueSeparator `constants`

##### Summary

Protected field for array of char of separator of field values

<a name='F-IniSharpBox-IniConfig-_MULTIVALUESEPARATOR'></a>
### _MULTIVALUESEPARATOR `constants`

##### Summary

Protected filed for separator of field values

<a name='P-IniSharpBox-IniConfig-ArrMultiValueSeparator'></a>
### ArrMultiValueSeparator `property`

##### Summary

Return array of char of separator of field values

<a name='P-IniSharpBox-IniConfig-BYINDEX'></a>
### BYINDEX `property`

##### Summary

Return strategy for accessor property

<a name='P-IniSharpBox-IniConfig-BYNAME'></a>
### BYNAME `property`

##### Summary

Return strategy for accessor property

<a name='P-IniSharpBox-IniConfig-MULTIVALUESEPARATOR'></a>
### MULTIVALUESEPARATOR `property`

##### Summary

Return separator enum of field values

<a name='T-IniSharpBox-IniItem'></a>
## IniItem `type`

##### Namespace

IniSharpBox

##### Summary

Abstact class for single item

<a name='F-IniSharpBox-IniItem-_Initialize'></a>
### _Initialize `constants`

##### Summary

Protected field for inizialization of object status

<a name='P-IniSharpBox-IniItem-Comments'></a>
### Comments `property`

##### Summary

Contains comment after declation of Section or Field

<a name='P-IniSharpBox-IniItem-Initialize'></a>
### Initialize `property`

##### Summary

State of inizialization of object

<a name='P-IniSharpBox-IniItem-Name'></a>
### Name `property`

##### Summary

Name of section or field

<a name='T-IniSharpBox-IniItemList'></a>
## IniItemList `type`

##### Namespace

IniSharpBox

##### Summary

Abstract class for list of items

<a name='M-IniSharpBox-IniItemList-Contains-System-Collections-Generic-List{IniSharpBox-IniItem},IniSharpBox-IniItem-'></a>
### Contains(container,item) `method`

##### Summary

Return true if item is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [System.Collections.Generic.List{IniSharpBox.IniItem}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{IniSharpBox.IniItem}') |  |
| item | [IniSharpBox.IniItem](#T-IniSharpBox-IniItem 'IniSharpBox.IniItem') |  |

<a name='M-IniSharpBox-IniItemList-Contains-System-Collections-Generic-List{IniSharpBox-IniItem},System-String-'></a>
### Contains(container,name) `method`

##### Summary

Return true if an item with Name == name is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [System.Collections.Generic.List{IniSharpBox.IniItem}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{IniSharpBox.IniItem}') |  |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniItemList-Contains-System-Collections-Generic-List{IniSharpBox-IniItem},System-Int32-'></a>
### Contains(container,index) `method`

##### Summary

Return true if an item with index is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [System.Collections.Generic.List{IniSharpBox.IniItem}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{IniSharpBox.IniItem}') |  |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-IniSharpNet-Conversion-IniJsonInterop'></a>
## IniJsonInterop `type`

##### Namespace

IniSharpNet.Conversion

##### Summary

Defines interoperability functions for INI and JSON.
 Thanks to J. Ritchie Carroll (ritchiecarroll : https://gist.github.com/ritchiecarroll )

 https://gist.github.com/ritchiecarroll/42909ef62e8597c58ee2301fd2a05e3c

<a name='M-IniSharpNet-Conversion-IniJsonInterop-GetIniAsJson-System-String,System-Boolean,System-Boolean-'></a>
### GetIniAsJson(value,indented,preserveComments) `method`

##### Summary

Gets INI as JSON.

##### Returns

Converted JSON.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | INI source. |
| indented | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to indent result JSON; otherwise, `false`. |
| preserveComments | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to preserve comments; otherwise, `false`. |

<a name='M-IniSharpNet-Conversion-IniJsonInterop-GetJsonAsIni-System-String,System-Boolean-'></a>
### GetJsonAsIni(value,restoreComments) `method`

##### Summary

Gets JSON as INI.

##### Returns

Converted INI.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | JSON source. |
| restoreComments | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | `true` to restore comments; otherwise, `false`. |

<a name='M-IniSharpNet-Conversion-IniJsonInterop-JavaScriptEncode-System-String-'></a>
### JavaScriptEncode(value) `method`

##### Summary

Performs JavaScript encoding on given string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to be encoded. |

<a name='T-IniSharpBox-IniSharp'></a>
## IniSharp `type`

##### Namespace

IniSharpBox

##### Summary

Class for manage ini file

<a name='M-IniSharpBox-IniSharp-#ctor-System-String,IniSharpBox-IniConfig-'></a>
### #ctor(filename,config) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-IniSharp-#ctor-System-String-'></a>
### #ctor(filename) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-#ctor-System-IO-FileInfo,IniSharpBox-IniConfig-'></a>
### #ctor(filename,config) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-IniSharp-#ctor-System-IO-FileInfo-'></a>
### #ctor(filename) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |

<a name='M-IniSharpBox-IniSharp-#ctor-IniSharpBox-IniConfig-'></a>
### #ctor(config) `constructor`

##### Summary

Constructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-IniSharp-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='F-IniSharpBox-IniSharp-_Errors'></a>
### _Errors `constants`

##### Summary

List of verbose error

<a name='F-IniSharpBox-IniSharp-_Exceptions'></a>
### _Exceptions `constants`

##### Summary

List of verbose Exceptions

<a name='P-IniSharpBox-IniSharp-EnableDebug'></a>
### EnableDebug `property`

##### Summary

Get/Set trace debug

<a name='P-IniSharpBox-IniSharp-Error'></a>
### Error `property`

##### Summary

Return true if an error occur during file parsing ,otherwise false (negate of Success)

<a name='P-IniSharpBox-IniSharp-Errors'></a>
### Errors `property`

##### Summary

Return list of verbose error

<a name='P-IniSharpBox-IniSharp-Exceptions'></a>
### Exceptions `property`

##### Summary

Return list of verbose error

<a name='P-IniSharpBox-IniSharp-HasException'></a>
### HasException `property`

##### Summary

Return true if an exception occur during file parsing , otherwise false

<a name='P-IniSharpBox-IniSharp-Item-System-Int32-'></a>
### Item `property`

##### Summary

Indexer declaration
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-IniSharpBox-IniSharp-Item-System-String-'></a>
### Item `property`

##### Summary

Indexer declaration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-IniSharpBox-IniSharp-Sections'></a>
### Sections `property`

##### Summary

List of section of ini file

<a name='P-IniSharpBox-IniSharp-Success'></a>
### Success `property`

##### Summary

Return true if parsing susseed , otherwise false  (negate of Error)

<a name='M-IniSharpBox-IniSharp-Check-System-Int32,System-Int32,System-Int32-'></a>
### Check(section,field,indexvalue) `method`

##### Summary

Return status of get/set operation
-2 : section do not exist
-1 : section exist , field do not exit
0  : section , field and index value exist
+1 : section , field exist but indexvalue eccede by 1 of current Lines count
+2 : section , field exist but indexvalue eccede by more than 1 of current Lines count

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-Check-System-Int32,System-String,System-Int32-'></a>
### Check(section,field,indexvalue) `method`

##### Summary

Return status of get/set operation
-2 : section do not exist
-1 : section exist , field do not exit
0  : section , field and index value exist
+1 : section , field exist but indexvalue eccede by 1 of current Lines count
+2 : section , field exist but indexvalue eccede by more than 1 of current Lines count

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| field | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-Check-System-String,System-Int32,System-Int32-'></a>
### Check(section,field,indexvalue) `method`

##### Summary

Return status of get/set operation
-2 : section do not exist
-1 : section exist , field do not exit
0  : section , field and index value exist
+1 : section , field exist but indexvalue eccede by 1 of current Lines count
+2 : section , field exist but indexvalue eccede by more than 1 of current Lines count

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-Check-System-String,System-String,System-Int32-'></a>
### Check(section,field,indexvalue) `method`

##### Summary

Return status of get/set operation
-2 : section do not exist
-1 : section exist , field do not exit
0  : section , field and index value exist
+1 : section , field exist but indexvalue eccede by 1 of current Lines count
+2 : section , field exist but indexvalue eccede by more than 1 of current Lines count

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| field | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-GetValue-System-Int32,System-Int32,System-Int32-'></a>
### GetValue(section,field,indexvalue) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-GetValue-System-Int32,System-String,System-Int32-'></a>
### GetValue(section,field,indexvalue) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| field | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-GetValue-System-String,System-Int32,System-Int32-'></a>
### GetValue(section,field,indexvalue) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-GetValue-System-String,System-String,System-Int32-'></a>
### GetValue(section,field,indexvalue) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| field | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-IniSharp-Read-System-String-'></a>
### Read(text) `method`

##### Summary

Parse a ini file passed as string
Ex : File.ReadAllText

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-Read-System-String[]-'></a>
### Read(lines) `method`

##### Summary

Parse a ini file passed as array of string
Ex : File.ReadAllLines

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-IniSharpBox-IniSharp-Read'></a>
### Read() `method`

##### Summary

Parse a ini file , filename is passed by constructor

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-IniSharp-SetValue-System-Int32,System-Int32,System-Int32,System-String-'></a>
### SetValue(section,field,indexvalue,value) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-SetValue-System-Int32,System-String,System-Int32,System-String-'></a>
### SetValue(section,field,indexvalue,value) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| field | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-SetValue-System-String,System-Int32,System-Int32,System-String-'></a>
### SetValue(section,field,indexvalue,value) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| field | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-SetValue-System-String,System-String,System-Int32,System-String-'></a>
### SetValue(section,field,indexvalue,value) `method`

##### Summary

Return value if exist , otherwise null

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| section | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| field | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| indexvalue | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-Write-System-IO-FileInfo,System-Boolean-'></a>
### Write(fi,overWrite) `method`

##### Summary

Write ini file on disk

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fi | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| overWrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-IniSharpBox-IniSharp-_Constructor-System-IO-FileInfo,IniSharpBox-IniConfig-'></a>
### _Constructor(filename,config) `method`

##### Summary

Inner construct of class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-IniSharp-_Read-System-String[]-'></a>
### _Read(lines) `method`

##### Summary

Inner method : parse a ini file passed as array of string

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='T-IniSharpBox-MULTIVALUESEPARATOR'></a>
## MULTIVALUESEPARATOR `type`

##### Namespace

IniSharpBox

##### Summary

Definition of separator of multi value Field for parsing ini file

<a name='F-IniSharpBox-MULTIVALUESEPARATOR-COMMA'></a>
### COMMA `constants`

##### Summary

Use "," as multi value separator

<a name='F-IniSharpBox-MULTIVALUESEPARATOR-NEWLINE'></a>
### NEWLINE `constants`

##### Summary

Use  "\r\n", "\r", "\n" as multi value separator

<a name='F-IniSharpBox-MULTIVALUESEPARATOR-PIPE'></a>
### PIPE `constants`

##### Summary

Use "|" as multi value separator

<a name='T-IniSharpBox-PARSE_STATE'></a>
## PARSE_STATE `type`

##### Namespace

IniSharpBox

##### Summary

State used during parsing of ini file

<a name='F-IniSharpBox-PARSE_STATE-COMMENT'></a>
### COMMENT `constants`

##### Summary

A comment is detected

<a name='F-IniSharpBox-PARSE_STATE-EMPTY_LINE'></a>
### EMPTY_LINE `constants`

##### Summary

an empty line is detected

<a name='F-IniSharpBox-PARSE_STATE-FIELD'></a>
### FIELD `constants`

##### Summary

A Field is detected

<a name='F-IniSharpBox-PARSE_STATE-INIT'></a>
### INIT `constants`

##### Summary

At start of file

<a name='F-IniSharpBox-PARSE_STATE-SECTION'></a>
### SECTION `constants`

##### Summary

A Section is detected

<a name='T-IniSharpBox-Section'></a>
## Section `type`

##### Namespace

IniSharpBox

##### Summary

Class for manage section of ini file

<a name='M-IniSharpBox-Section-#ctor-System-Int32,IniSharpBox-IniConfig-'></a>
### #ctor(id,config) `constructor`

##### Summary

Contructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-Section-#ctor-System-Int32,System-String,IniSharpBox-IniConfig-'></a>
### #ctor(id,name,config) `constructor`

##### Summary

Contructor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-Section-#ctor-IniSharpBox-IniConfig-'></a>
### #ctor() `constructor`

##### Summary

Contructor

##### Parameters

This constructor has no parameters.

<a name='P-IniSharpBox-Section-Fields'></a>
### Fields `property`

##### Summary

Property for retrive fields

<a name='P-IniSharpBox-Section-Item-System-Int32-'></a>
### Item `property`

##### Summary

Indexer declaration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-IniSharpBox-Section-Item-System-String-'></a>
### Item `property`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Section-Add-IniSharpBox-Field-'></a>
### Add(item) `method`

##### Summary

Add new field

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [IniSharpBox.Field](#T-IniSharpBox-Field 'IniSharpBox.Field') |  |

<a name='M-IniSharpBox-Section-Last'></a>
### Last() `method`

##### Summary

Return last field

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-Section-Write'></a>
### Write() `method`

##### Summary

Return fields strings

##### Returns



##### Parameters

This method has no parameters.

<a name='T-IniSharpBox-Sections'></a>
## Sections `type`

##### Namespace

IniSharpBox

##### Summary

Class for manage list of section of ini file

<a name='M-IniSharpBox-Sections-#ctor-IniSharpBox-IniConfig-'></a>
### #ctor() `constructor`

##### Summary

Contructor

##### Parameters

This constructor has no parameters.

<a name='P-IniSharpBox-Sections-Count'></a>
### Count `property`

##### Summary

Return number of item

<a name='P-IniSharpBox-Sections-Item-System-Int32-'></a>
### Item `property`

##### Summary

Indexer declaration
https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-IniSharpBox-Sections-Item-System-String-'></a>
### Item `property`

##### Summary

Indexer declaration

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-IniSharpBox-Sections-Section'></a>
### Section `property`

##### Summary

List of section

<a name='M-IniSharpBox-Sections-Add-IniSharpBox-Section-'></a>
### Add(item) `method`

##### Summary

Add a new section

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [IniSharpBox.Section](#T-IniSharpBox-Section 'IniSharpBox.Section') |  |

<a name='M-IniSharpBox-Sections-Add-System-String-'></a>
### Add(name) `method`

##### Summary

Add a new empty section with name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Sections-Clear'></a>
### Clear() `method`

##### Summary

Cleal list of section

##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-Sections-Contains-IniSharpBox-Section-'></a>
### Contains(item) `method`

##### Summary

Return true if item is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [IniSharpBox.Section](#T-IniSharpBox-Section 'IniSharpBox.Section') |  |

<a name='M-IniSharpBox-Sections-Contains-System-String-'></a>
### Contains(name) `method`

##### Summary

Return true if an item with Name == name is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Sections-Contains-System-Int32-'></a>
### Contains(index) `method`

##### Summary

Return true if an item with index is present in list , otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-Sections-GetByName-System-String-'></a>
### GetByName(name) `method`

##### Summary

Return section by name

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Sections-Write'></a>
### Write() `method`

##### Summary

Return Sections stirngs

##### Returns



##### Parameters

This method has no parameters.
