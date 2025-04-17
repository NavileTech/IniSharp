<a name='assembly'></a>
# IniSharpNet

## Contents

- [ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE')
  - [DO_SECTION](#F-IniSharpBox-ALLOWDUPLICATE-DO_SECTION 'IniSharpBox.ALLOWDUPLICATE.DO_SECTION')
  - [NOT_SECTION_DO_FIELD](#F-IniSharpBox-ALLOWDUPLICATE-NOT_SECTION_DO_FIELD 'IniSharpBox.ALLOWDUPLICATE.NOT_SECTION_DO_FIELD')
  - [NOT_SECTION_NOT_FIELD_DO_VALUE](#F-IniSharpBox-ALLOWDUPLICATE-NOT_SECTION_NOT_FIELD_DO_VALUE 'IniSharpBox.ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_DO_VALUE')
  - [NOT_SECTION_NOT_FIELD_NOT_VALUE](#F-IniSharpBox-ALLOWDUPLICATE-NOT_SECTION_NOT_FIELD_NOT_VALUE 'IniSharpBox.ALLOWDUPLICATE.NOT_SECTION_NOT_FIELD_NOT_VALUE')
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
  - [Merge(first,second,duplicate)](#M-IniSharpBox-Field-Merge-IniSharpBox-Field,IniSharpBox-Field,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.Field.Merge(IniSharpBox.Field,IniSharpBox.Field,IniSharpBox.ALLOWDUPLICATE)')
  - [Remove(value)](#M-IniSharpBox-Field-Remove-System-String- 'IniSharpBox.Field.Remove(System.String)')
  - [Remove(index)](#M-IniSharpBox-Field-Remove-System-Int32- 'IniSharpBox.Field.Remove(System.Int32)')
  - [Replace(line)](#M-IniSharpBox-Field-Replace-System-String- 'IniSharpBox.Field.Replace(System.String)')
  - [Replace(lines)](#M-IniSharpBox-Field-Replace-System-Collections-Generic-List{System-String}- 'IniSharpBox.Field.Replace(System.Collections.Generic.List{System.String})')
  - [Replace(lines)](#M-IniSharpBox-Field-Replace-System-String[]- 'IniSharpBox.Field.Replace(System.String[])')
  - [ToSortedText()](#M-IniSharpBox-Field-ToSortedText 'IniSharpBox.Field.ToSortedText')
  - [ToText()](#M-IniSharpBox-Field-ToText 'IniSharpBox.Field.ToText')
- [Fields](#T-IniSharpBox-Fields 'IniSharpBox.Fields')
  - [#ctor()](#M-IniSharpBox-Fields-#ctor 'IniSharpBox.Fields.#ctor')
  - [#ctor()](#M-IniSharpBox-Fields-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.Fields.#ctor(IniSharpBox.IniConfig)')
  - [Childs](#P-IniSharpBox-Fields-Childs 'IniSharpBox.Fields.Childs')
  - [Count](#P-IniSharpBox-Fields-Count 'IniSharpBox.Fields.Count')
  - [GetNames](#P-IniSharpBox-Fields-GetNames 'IniSharpBox.Fields.GetNames')
  - [Item](#P-IniSharpBox-Fields-Item-System-Int32- 'IniSharpBox.Fields.Item(System.Int32)')
  - [Item](#P-IniSharpBox-Fields-Item-System-String- 'IniSharpBox.Fields.Item(System.String)')
  - [Add(item)](#M-IniSharpBox-Fields-Add-IniSharpBox-Field- 'IniSharpBox.Fields.Add(IniSharpBox.Field)')
  - [Contains(item)](#M-IniSharpBox-Fields-Contains-IniSharpBox-Field- 'IniSharpBox.Fields.Contains(IniSharpBox.Field)')
  - [Contains(name)](#M-IniSharpBox-Fields-Contains-System-String- 'IniSharpBox.Fields.Contains(System.String)')
  - [Contains(index)](#M-IniSharpBox-Fields-Contains-System-Int32- 'IniSharpBox.Fields.Contains(System.Int32)')
  - [GetByName(name)](#M-IniSharpBox-Fields-GetByName-System-String- 'IniSharpBox.Fields.GetByName(System.String)')
  - [Merge(first,second,duplicate)](#M-IniSharpBox-Fields-Merge-IniSharpBox-Fields,IniSharpBox-Fields,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.Fields.Merge(IniSharpBox.Fields,IniSharpBox.Fields,IniSharpBox.ALLOWDUPLICATE)')
  - [Remove(name)](#M-IniSharpBox-Fields-Remove-System-String- 'IniSharpBox.Fields.Remove(System.String)')
  - [Remove(index)](#M-IniSharpBox-Fields-Remove-System-Int32- 'IniSharpBox.Fields.Remove(System.Int32)')
  - [ToSortedText()](#M-IniSharpBox-Fields-ToSortedText 'IniSharpBox.Fields.ToSortedText')
  - [ToText()](#M-IniSharpBox-Fields-ToText 'IniSharpBox.Fields.ToText')
- [Helpers](#T-IniSharpNet-Helpers 'IniSharpNet.Helpers')
  - [MULTIVALUESEPARATORs](#P-IniSharpNet-Helpers-MULTIVALUESEPARATORs 'IniSharpNet.Helpers.MULTIVALUESEPARATORs')
  - [ListOfStringToStringBuilderAppendLine(elements)](#M-IniSharpNet-Helpers-ListOfStringToStringBuilderAppendLine-System-Collections-Generic-List{System-String}- 'IniSharpNet.Helpers.ListOfStringToStringBuilderAppendLine(System.Collections.Generic.List{System.String})')
  - [Space(number)](#M-IniSharpNet-Helpers-Space-System-Int32- 'IniSharpNet.Helpers.Space(System.Int32)')
  - [StringIfLess(reference,breakeven,iftrue,iffalse)](#M-IniSharpNet-Helpers-StringIfLess-System-Int32,System-Int32,System-String,System-String- 'IniSharpNet.Helpers.StringIfLess(System.Int32,System.Int32,System.String,System.String)')
  - [WriteToFile(fi,text,overWrite)](#M-IniSharpNet-Helpers-WriteToFile-System-IO-FileInfo,System-String,System-Boolean- 'IniSharpNet.Helpers.WriteToFile(System.IO.FileInfo,System.String,System.Boolean)')
- [IIniItemRemove](#T-IniSharpBox-IIniItemRemove 'IniSharpBox.IIniItemRemove')
  - [Remove(name)](#M-IniSharpBox-IIniItemRemove-Remove-System-String- 'IniSharpBox.IIniItemRemove.Remove(System.String)')
  - [Remove(index)](#M-IniSharpBox-IIniItemRemove-Remove-System-Int32- 'IniSharpBox.IIniItemRemove.Remove(System.Int32)')
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
- [IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp')
  - [#ctor()](#M-IniSharpBox-IniSharp-#ctor 'IniSharpBox.IniSharp.#ctor')
  - [#ctor(filename,config)](#M-IniSharpBox-IniSharp-#ctor-System-String,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.#ctor(System.String,IniSharpBox.IniConfig)')
  - [#ctor(filename)](#M-IniSharpBox-IniSharp-#ctor-System-String- 'IniSharpBox.IniSharp.#ctor(System.String)')
  - [#ctor(filename,config)](#M-IniSharpBox-IniSharp-#ctor-System-IO-FileInfo,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.#ctor(System.IO.FileInfo,IniSharpBox.IniConfig)')
  - [#ctor(filename)](#M-IniSharpBox-IniSharp-#ctor-System-IO-FileInfo- 'IniSharpBox.IniSharp.#ctor(System.IO.FileInfo)')
  - [#ctor(config)](#M-IniSharpBox-IniSharp-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.#ctor(IniSharpBox.IniConfig)')
  - [TAB](#F-IniSharpBox-IniSharp-TAB 'IniSharpBox.IniSharp.TAB')
  - [_Errors](#F-IniSharpBox-IniSharp-_Errors 'IniSharpBox.IniSharp._Errors')
  - [_Exceptions](#F-IniSharpBox-IniSharp-_Exceptions 'IniSharpBox.IniSharp._Exceptions')
  - [Body](#P-IniSharpBox-IniSharp-Body 'IniSharpBox.IniSharp.Body')
  - [EnableDebug](#P-IniSharpBox-IniSharp-EnableDebug 'IniSharpBox.IniSharp.EnableDebug')
  - [Error](#P-IniSharpBox-IniSharp-Error 'IniSharpBox.IniSharp.Error')
  - [Errors](#P-IniSharpBox-IniSharp-Errors 'IniSharpBox.IniSharp.Errors')
  - [Exceptions](#P-IniSharpBox-IniSharp-Exceptions 'IniSharpBox.IniSharp.Exceptions')
  - [HasException](#P-IniSharpBox-IniSharp-HasException 'IniSharpBox.IniSharp.HasException')
  - [Item](#P-IniSharpBox-IniSharp-Item-System-Int32- 'IniSharpBox.IniSharp.Item(System.Int32)')
  - [Item](#P-IniSharpBox-IniSharp-Item-System-String- 'IniSharpBox.IniSharp.Item(System.String)')
  - [Success](#P-IniSharpBox-IniSharp-Success 'IniSharpBox.IniSharp.Success')
  - [AreEquals(first,second)](#M-IniSharpBox-IniSharp-AreEquals-IniSharpBox-IniSharp,IniSharpBox-IniSharp- 'IniSharpBox.IniSharp.AreEquals(IniSharpBox.IniSharp,IniSharpBox.IniSharp)')
  - [BaseRead(lines)](#M-IniSharpBox-IniSharp-BaseRead-System-String[]- 'IniSharpBox.IniSharp.BaseRead(System.String[])')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-Int32,System-Int32,System-Int32- 'IniSharpBox.IniSharp.Check(System.Int32,System.Int32,System.Int32)')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-Int32,System-String,System-Int32- 'IniSharpBox.IniSharp.Check(System.Int32,System.String,System.Int32)')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-String,System-Int32,System-Int32- 'IniSharpBox.IniSharp.Check(System.String,System.Int32,System.Int32)')
  - [Check(section,field,indexvalue)](#M-IniSharpBox-IniSharp-Check-System-String,System-String,System-Int32- 'IniSharpBox.IniSharp.Check(System.String,System.String,System.Int32)')
  - [Compare(first,second,third)](#M-IniSharpBox-IniSharp-Compare-IniSharpBox-IniSharp,IniSharpBox-IniSharp,IniSharpBox-IniSharp- 'IniSharpBox.IniSharp.Compare(IniSharpBox.IniSharp,IniSharpBox.IniSharp,IniSharpBox.IniSharp)')
  - [Constructor(filename,config)](#M-IniSharpBox-IniSharp-Constructor-System-IO-FileInfo,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.Constructor(System.IO.FileInfo,IniSharpBox.IniConfig)')
  - [Equals(other)](#M-IniSharpBox-IniSharp-Equals-IniSharpBox-IniSharp- 'IniSharpBox.IniSharp.Equals(IniSharpBox.IniSharp)')
  - [FromJson(text)](#M-IniSharpBox-IniSharp-FromJson-System-String- 'IniSharpBox.IniSharp.FromJson(System.String)')
  - [FromJsonDeserialize(text)](#M-IniSharpBox-IniSharp-FromJsonDeserialize-System-String- 'IniSharpBox.IniSharp.FromJsonDeserialize(System.String)')
  - [FromXml(text)](#M-IniSharpBox-IniSharp-FromXml-System-String- 'IniSharpBox.IniSharp.FromXml(System.String)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-Int32,System-Int32,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.Int32,System.Int32,System.Int32)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-Int32,System-String,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.Int32,System.String,System.Int32)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-String,System-Int32,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.String,System.Int32,System.Int32)')
  - [GetValue(section,field,indexvalue)](#M-IniSharpBox-IniSharp-GetValue-System-String,System-String,System-Int32- 'IniSharpBox.IniSharp.GetValue(System.String,System.String,System.Int32)')
  - [Hash()](#M-IniSharpBox-IniSharp-Hash 'IniSharpBox.IniSharp.Hash')
  - [Import(other,duplicate)](#M-IniSharpBox-IniSharp-Import-IniSharpBox-IniSharp,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Import(IniSharpBox.IniSharp,IniSharpBox.ALLOWDUPLICATE)')
  - [Import(other,config,duplicate)](#M-IniSharpBox-IniSharp-Import-System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Import(System.IO.FileInfo,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Import(other,config,duplicate)](#M-IniSharpBox-IniSharp-Import-System-String,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Import(System.String,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Load(fi,config)](#M-IniSharpBox-IniSharp-Load-System-IO-FileInfo,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.Load(System.IO.FileInfo,IniSharpBox.IniConfig)')
  - [Load(text,config)](#M-IniSharpBox-IniSharp-Load-System-String,IniSharpBox-IniConfig- 'IniSharpBox.IniSharp.Load(System.String,IniSharpBox.IniConfig)')
  - [Merge(first,second,firstConfig,secondConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.IO.FileInfo,System.IO.FileInfo,IniSharpBox.IniConfig,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,firstConfig,secondConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,System-String,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.IO.FileInfo,System.String,IniSharpBox.IniConfig,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,firstConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,IniSharpBox-IniSharp,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.IO.FileInfo,IniSharpBox.IniSharp,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,firstConfig,secondConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-String,System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.String,System.IO.FileInfo,IniSharpBox.IniConfig,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,firstConfig,secondConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-String,System-String,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.String,System.String,IniSharpBox.IniConfig,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,firstConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-String,IniSharpBox-IniSharp,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.String,IniSharpBox.IniSharp,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,secondConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(IniSharpBox.IniSharp,System.IO.FileInfo,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,secondConfig,duplicate)](#M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,System-String,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(IniSharpBox.IniSharp,System.String,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(first,second,duplicate)](#M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,IniSharpBox-IniSharp,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(IniSharpBox.IniSharp,IniSharpBox.IniSharp,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(other,duplicate)](#M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(IniSharpBox.IniSharp,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(other,config,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-String,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.String,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Merge(other,config,duplicate)](#M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.IniSharp.Merge(System.IO.FileInfo,IniSharpBox.IniConfig,IniSharpBox.ALLOWDUPLICATE)')
  - [Read(text)](#M-IniSharpBox-IniSharp-Read-System-String- 'IniSharpBox.IniSharp.Read(System.String)')
  - [Read(lines)](#M-IniSharpBox-IniSharp-Read-System-String[]- 'IniSharpBox.IniSharp.Read(System.String[])')
  - [Read()](#M-IniSharpBox-IniSharp-Read 'IniSharpBox.IniSharp.Read')
  - [Remove(name)](#M-IniSharpBox-IniSharp-Remove-System-String- 'IniSharpBox.IniSharp.Remove(System.String)')
  - [Remove(index)](#M-IniSharpBox-IniSharp-Remove-System-Int32- 'IniSharpBox.IniSharp.Remove(System.Int32)')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-Int32,System-Int32,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.Int32,System.Int32,System.Int32,System.String)')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-Int32,System-String,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.Int32,System.String,System.Int32,System.String)')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-String,System-Int32,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.String,System.Int32,System.Int32,System.String)')
  - [SetValue(section,field,indexvalue,value)](#M-IniSharpBox-IniSharp-SetValue-System-String,System-String,System-Int32,System-String- 'IniSharpBox.IniSharp.SetValue(System.String,System.String,System.Int32,System.String)')
  - [SortedWrite(fi,overWrite)](#M-IniSharpBox-IniSharp-SortedWrite-System-IO-FileInfo,System-Boolean- 'IniSharpBox.IniSharp.SortedWrite(System.IO.FileInfo,System.Boolean)')
  - [ToJson()](#M-IniSharpBox-IniSharp-ToJson 'IniSharpBox.IniSharp.ToJson')
  - [ToJsonSerialize()](#M-IniSharpBox-IniSharp-ToJsonSerialize 'IniSharpBox.IniSharp.ToJsonSerialize')
  - [ToSortedText()](#M-IniSharpBox-IniSharp-ToSortedText 'IniSharpBox.IniSharp.ToSortedText')
  - [ToText()](#M-IniSharpBox-IniSharp-ToText 'IniSharpBox.IniSharp.ToText')
  - [ToXml()](#M-IniSharpBox-IniSharp-ToXml 'IniSharpBox.IniSharp.ToXml')
  - [ValidateEquals(first,second)](#M-IniSharpBox-IniSharp-ValidateEquals-IniSharpBox-IniSharp,IniSharpBox-IniSharp- 'IniSharpBox.IniSharp.ValidateEquals(IniSharpBox.IniSharp,IniSharpBox.IniSharp)')
  - [Write(fi,overWrite)](#M-IniSharpBox-IniSharp-Write-System-IO-FileInfo,System-Boolean- 'IniSharpBox.IniSharp.Write(System.IO.FileInfo,System.Boolean)')
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
  - [#ctor()](#M-IniSharpBox-Section-#ctor 'IniSharpBox.Section.#ctor')
  - [Fields](#P-IniSharpBox-Section-Fields 'IniSharpBox.Section.Fields')
  - [Item](#P-IniSharpBox-Section-Item-System-Int32- 'IniSharpBox.Section.Item(System.Int32)')
  - [Item](#P-IniSharpBox-Section-Item-System-String- 'IniSharpBox.Section.Item(System.String)')
  - [Add(item)](#M-IniSharpBox-Section-Add-IniSharpBox-Field- 'IniSharpBox.Section.Add(IniSharpBox.Field)')
  - [Last()](#M-IniSharpBox-Section-Last 'IniSharpBox.Section.Last')
  - [Merge(first,second,duplicate)](#M-IniSharpBox-Section-Merge-IniSharpBox-Section,IniSharpBox-Section,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.Section.Merge(IniSharpBox.Section,IniSharpBox.Section,IniSharpBox.ALLOWDUPLICATE)')
  - [ToSortedText()](#M-IniSharpBox-Section-ToSortedText 'IniSharpBox.Section.ToSortedText')
  - [ToText()](#M-IniSharpBox-Section-ToText 'IniSharpBox.Section.ToText')
- [Sections](#T-IniSharpBox-Sections 'IniSharpBox.Sections')
  - [#ctor()](#M-IniSharpBox-Sections-#ctor-IniSharpBox-IniConfig- 'IniSharpBox.Sections.#ctor(IniSharpBox.IniConfig)')
  - [#ctor()](#M-IniSharpBox-Sections-#ctor 'IniSharpBox.Sections.#ctor')
  - [Childs](#P-IniSharpBox-Sections-Childs 'IniSharpBox.Sections.Childs')
  - [Count](#P-IniSharpBox-Sections-Count 'IniSharpBox.Sections.Count')
  - [GetNames](#P-IniSharpBox-Sections-GetNames 'IniSharpBox.Sections.GetNames')
  - [Item](#P-IniSharpBox-Sections-Item-System-Int32- 'IniSharpBox.Sections.Item(System.Int32)')
  - [Item](#P-IniSharpBox-Sections-Item-System-String- 'IniSharpBox.Sections.Item(System.String)')
  - [Add(item)](#M-IniSharpBox-Sections-Add-IniSharpBox-Section- 'IniSharpBox.Sections.Add(IniSharpBox.Section)')
  - [Add(name)](#M-IniSharpBox-Sections-Add-System-String- 'IniSharpBox.Sections.Add(System.String)')
  - [Clear()](#M-IniSharpBox-Sections-Clear 'IniSharpBox.Sections.Clear')
  - [Contains(item)](#M-IniSharpBox-Sections-Contains-IniSharpBox-Section- 'IniSharpBox.Sections.Contains(IniSharpBox.Section)')
  - [Contains(name)](#M-IniSharpBox-Sections-Contains-System-String- 'IniSharpBox.Sections.Contains(System.String)')
  - [Contains(index)](#M-IniSharpBox-Sections-Contains-System-Int32- 'IniSharpBox.Sections.Contains(System.Int32)')
  - [GetByName(name)](#M-IniSharpBox-Sections-GetByName-System-String- 'IniSharpBox.Sections.GetByName(System.String)')
  - [Merge(first,second,duplicate)](#M-IniSharpBox-Sections-Merge-IniSharpBox-Sections,IniSharpBox-Sections,IniSharpBox-ALLOWDUPLICATE- 'IniSharpBox.Sections.Merge(IniSharpBox.Sections,IniSharpBox.Sections,IniSharpBox.ALLOWDUPLICATE)')
  - [Remove(name)](#M-IniSharpBox-Sections-Remove-System-String- 'IniSharpBox.Sections.Remove(System.String)')
  - [Remove(index)](#M-IniSharpBox-Sections-Remove-System-Int32- 'IniSharpBox.Sections.Remove(System.Int32)')
  - [ToSortedText()](#M-IniSharpBox-Sections-ToSortedText 'IniSharpBox.Sections.ToSortedText')
  - [ToText()](#M-IniSharpBox-Sections-ToText 'IniSharpBox.Sections.ToText')

<a name='T-IniSharpBox-ALLOWDUPLICATE'></a>
## ALLOWDUPLICATE `type`

##### Namespace

IniSharpBox

##### Summary

Duplicate\Merge strategy used by Merge methods

<a name='F-IniSharpBox-ALLOWDUPLICATE-DO_SECTION'></a>
### DO_SECTION `constants`

##### Summary

If two section with same Name duplicate them writing in order

<a name='F-IniSharpBox-ALLOWDUPLICATE-NOT_SECTION_DO_FIELD'></a>
### NOT_SECTION_DO_FIELD `constants`

##### Summary

If two section with same Name merge them in one and follow next strategy , otherwise duplicate the sections
If two field   with same Name (in two section with same Name) duplicate them writing in order (first then second)

<a name='F-IniSharpBox-ALLOWDUPLICATE-NOT_SECTION_NOT_FIELD_DO_VALUE'></a>
### NOT_SECTION_NOT_FIELD_DO_VALUE `constants`

##### Summary

If two section with same Name merge them in one and follow next strategy , otherwise duplicate the sections
If two field   with same Name (in two section with same Name) merge them in one and follow next strategy , otherwise duplicate the fields
If two field-value   with same value (in two section with same Name containig two field with same Name ) duplicate them  (first then second)

<a name='F-IniSharpBox-ALLOWDUPLICATE-NOT_SECTION_NOT_FIELD_NOT_VALUE'></a>
### NOT_SECTION_NOT_FIELD_NOT_VALUE `constants`

##### Summary

If two section with same Name merge them in one and follow next strategy , otherwise duplicate the sections
If two field   with same Name (in two section with same Name) merge them in one and follow next strategy , otherwise duplicate the fields
If two field-value   with same value (in two section with same Name containig two field with same Name ) merge them in one (pick first)

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

<a name='M-IniSharpBox-Field-Merge-IniSharpBox-Field,IniSharpBox-Field,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,duplicate) `method`

##### Summary

Return a Field as merged from 2 Field.
If duplicateValue is true allow multiple instance of value, otherwise do not allow duplicate instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.Field](#T-IniSharpBox-Field 'IniSharpBox.Field') |  |
| second | [IniSharpBox.Field](#T-IniSharpBox-Field 'IniSharpBox.Field') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-Field-Remove-System-String-'></a>
### Remove(value) `method`

##### Summary

Return true if an item with value exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Field-Remove-System-Int32-'></a>
### Remove(index) `method`

##### Summary

Return true if an item with index pass as argument exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

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

<a name='M-IniSharpBox-Field-ToSortedText'></a>
### ToSortedText() `method`

##### Summary

Return sorted field name/value

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-Field-ToText'></a>
### ToText() `method`

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

<a name='M-IniSharpBox-Fields-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor (parameterless)

##### Parameters

This constructor has no parameters.

<a name='M-IniSharpBox-Fields-#ctor-IniSharpBox-IniConfig-'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

<a name='P-IniSharpBox-Fields-Childs'></a>
### Childs `property`

##### Summary

List of fields

<a name='P-IniSharpBox-Fields-Count'></a>
### Count `property`

##### Summary

Return number of element of Field list

<a name='P-IniSharpBox-Fields-GetNames'></a>
### GetNames `property`

##### Summary

Returns a list of names of Field

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

<a name='M-IniSharpBox-Fields-Merge-IniSharpBox-Fields,IniSharpBox-Fields,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,duplicate) `method`

##### Summary

Return a merged Field from 2 input Field according to duplicate strategy

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.Fields](#T-IniSharpBox-Fields 'IniSharpBox.Fields') |  |
| second | [IniSharpBox.Fields](#T-IniSharpBox-Fields 'IniSharpBox.Fields') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-Fields-Remove-System-String-'></a>
### Remove(name) `method`

##### Summary

Return true if an item with name == Name exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Fields-Remove-System-Int32-'></a>
### Remove(index) `method`

##### Summary

Return true if an item with index pass as argument exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-Fields-ToSortedText'></a>
### ToSortedText() `method`

##### Summary

Return a sorted version ToText() without comments

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-Fields-ToText'></a>
### ToText() `method`

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

<a name='M-IniSharpNet-Helpers-ListOfStringToStringBuilderAppendLine-System-Collections-Generic-List{System-String}-'></a>
### ListOfStringToStringBuilderAppendLine(elements) `method`

##### Summary

Return a StringBuilder object loaded with AppendLine method using string from a list of string as argument

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.List{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.String}') |  |

<a name='M-IniSharpNet-Helpers-Space-System-Int32-'></a>
### Space(number) `method`

##### Summary

Return a string with number space as argument

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpNet-Helpers-StringIfLess-System-Int32,System-Int32,System-String,System-String-'></a>
### StringIfLess(reference,breakeven,iftrue,iffalse) `method`

##### Summary

Return iftrue string if breakeaven is less then reference, otherwise return iffalse

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| reference | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| breakeven | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| iftrue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| iffalse | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpNet-Helpers-WriteToFile-System-IO-FileInfo,System-String,System-Boolean-'></a>
### WriteToFile(fi,text,overWrite) `method`

##### Summary

Write on file fi a text , if file exist and overWrite is true then text is overwritten and return true ,
if file exist and overWrite is false then no text is written ,

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fi | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| overWrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-IniSharpBox-IIniItemRemove'></a>
## IIniItemRemove `type`

##### Namespace

IniSharpBox

##### Summary

Interface define methods for remove items

<a name='M-IniSharpBox-IIniItemRemove-Remove-System-String-'></a>
### Remove(name) `method`

##### Summary

Return true if an item with name == Name exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IIniItemRemove-Remove-System-Int32-'></a>
### Remove(index) `method`

##### Summary

Return true if an item with index pass as argument exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

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

<a name='T-IniSharpBox-IniSharp'></a>
## IniSharp `type`

##### Namespace

IniSharpBox

##### Summary

Class for manage ini file

<a name='M-IniSharpBox-IniSharp-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor

##### Parameters

This constructor has no parameters.

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

<a name='F-IniSharpBox-IniSharp-TAB'></a>
### TAB `constants`

##### Summary

Define tabulation for json custom formatting

<a name='F-IniSharpBox-IniSharp-_Errors'></a>
### _Errors `constants`

##### Summary

List of verbose error

<a name='F-IniSharpBox-IniSharp-_Exceptions'></a>
### _Exceptions `constants`

##### Summary

List of verbose Exceptions

<a name='P-IniSharpBox-IniSharp-Body'></a>
### Body `property`

##### Summary

List of section of ini file

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

<a name='P-IniSharpBox-IniSharp-Success'></a>
### Success `property`

##### Summary

Return true if parsing susseed , otherwise false  (negate of Error)

<a name='M-IniSharpBox-IniSharp-AreEquals-IniSharpBox-IniSharp,IniSharpBox-IniSharp-'></a>
### AreEquals(first,second) `method`

##### Summary

Return true if are equals according to ToSortedText(), otherwise false.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| second | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |

<a name='M-IniSharpBox-IniSharp-BaseRead-System-String[]-'></a>
### BaseRead(lines) `method`

##### Summary

Inner method : parse a ini file passed as array of string

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| lines | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

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

<a name='M-IniSharpBox-IniSharp-Compare-IniSharpBox-IniSharp,IniSharpBox-IniSharp,IniSharpBox-IniSharp-'></a>
### Compare(first,second,third) `method`

##### Summary

Return a value that show comparison status between 3 object

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| second | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| third | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |

<a name='M-IniSharpBox-IniSharp-Constructor-System-IO-FileInfo,IniSharpBox-IniConfig-'></a>
### Constructor(filename,config) `method`

##### Summary

Inner construct of class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filename | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-IniSharp-Equals-IniSharpBox-IniSharp-'></a>
### Equals(other) `method`

##### Summary

Return true if external object is equal

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |

<a name='M-IniSharpBox-IniSharp-FromJson-System-String-'></a>
### FromJson(text) `method`

##### Summary

Return true if deserialization of a serialized json custom formatted string succeded, otherwise false.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-FromJsonDeserialize-System-String-'></a>
### FromJsonDeserialize(text) `method`

##### Summary

Return true if deserialization of a serialized json Newtonsoft formatted string succeded, otherwise false.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-FromXml-System-String-'></a>
### FromXml(text) `method`

##### Summary

Return true if xml deserialization of a serialized xml string succeded, otherwise false.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

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

<a name='M-IniSharpBox-IniSharp-Hash'></a>
### Hash() `method`

##### Summary

Return an array get by computation of the SHA256 hash for an array achived from sorted text of ini file
https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm?view=net-9.0

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-IniSharp-Import-IniSharpBox-IniSharp,IniSharpBox-ALLOWDUPLICATE-'></a>
### Import(other,duplicate) `method`

##### Summary

Import inside this object a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
Imported object has config preference of this object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Import-System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Import(other,config,duplicate) `method`

##### Summary

Import inside this object a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
Imported object has config preference of this object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Import-System-String,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Import(other,config,duplicate) `method`

##### Summary

Import inside this object a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
Imported object has config preference of this object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Load-System-IO-FileInfo,IniSharpBox-IniConfig-'></a>
### Load(fi,config) `method`

##### Summary

Return an IniSharp object

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fi | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-IniSharp-Load-System-String,IniSharpBox-IniConfig-'></a>
### Load(text,config) `method`

##### Summary

Return an IniSharp object passing a text of ini file as argument

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,firstConfig,secondConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| second | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| firstConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| secondConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,System-String,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,firstConfig,secondConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| second | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| firstConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| secondConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,IniSharpBox-IniSharp,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,firstConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| second | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| firstConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-String,System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,firstConfig,secondConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| second | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| firstConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| secondConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-String,System-String,IniSharpBox-IniConfig,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,firstConfig,secondConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| second | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| firstConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| secondConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-String,IniSharpBox-IniSharp,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,firstConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| second | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| firstConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,secondConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| second | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| secondConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,System-String,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,secondConfig,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| second | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| secondConfig | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,IniSharpBox-IniSharp,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,duplicate) `method`

##### Summary

Return a merged IniSharp object from 2 IniSharp object provide as argument with duplicate option for every level of ini file (section, field, values).
Return object has config preference of first argument.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| second | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-IniSharpBox-IniSharp,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(other,duplicate) `method`

##### Summary

Return a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
Return object has config preference of this object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-String,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(other,config,duplicate) `method`

##### Summary

Return a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
Return object has config preference of this object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-IniSharp-Merge-System-IO-FileInfo,IniSharpBox-IniConfig,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(other,config,duplicate) `method`

##### Summary

Return a merged IniSharp object from external IniSharp object and this object the first is provide as argument with duplicate option for every level of ini file (section, field, values)
Return object has config preference of this object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| other | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| config | [IniSharpBox.IniConfig](#T-IniSharpBox-IniConfig 'IniSharpBox.IniConfig') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

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

<a name='M-IniSharpBox-IniSharp-Remove-System-String-'></a>
### Remove(name) `method`

##### Summary

Return true if an item with name == Name exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-IniSharp-Remove-System-Int32-'></a>
### Remove(index) `method`

##### Summary

Return true if an item with index pass as argument exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

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

<a name='M-IniSharpBox-IniSharp-SortedWrite-System-IO-FileInfo,System-Boolean-'></a>
### SortedWrite(fi,overWrite) `method`

##### Summary

Write a sorted ini file on disk

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fi | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') |  |
| overWrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-IniSharpBox-IniSharp-ToJson'></a>
### ToJson() `method`

##### Summary

Return a serialized json custom formatted string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-IniSharp-ToJsonSerialize'></a>
### ToJsonSerialize() `method`

##### Summary

Return a serialized json Newtonsoft formatted string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-IniSharp-ToSortedText'></a>
### ToSortedText() `method`

##### Summary

Returns a formatted sorted, by item name, ini file string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-IniSharp-ToText'></a>
### ToText() `method`

##### Summary

Return a formatted ini file string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-IniSharp-ToXml'></a>
### ToXml() `method`

##### Summary

Return a serialized xml formatted string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-IniSharp-ValidateEquals-IniSharpBox-IniSharp,IniSharpBox-IniSharp-'></a>
### ValidateEquals(first,second) `method`

##### Summary

Return true if are equals according to ToSortedText() + both has Success == true + both has ToSortedText().Length > 0 , otherwise false.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |
| second | [IniSharpBox.IniSharp](#T-IniSharpBox-IniSharp 'IniSharpBox.IniSharp') |  |

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

<a name='M-IniSharpBox-Section-#ctor'></a>
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

<a name='M-IniSharpBox-Section-Merge-IniSharpBox-Section,IniSharpBox-Section,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,duplicate) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.Section](#T-IniSharpBox-Section 'IniSharpBox.Section') |  |
| second | [IniSharpBox.Section](#T-IniSharpBox-Section 'IniSharpBox.Section') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-Section-ToSortedText'></a>
### ToSortedText() `method`

##### Summary

Return sorted fields strings , comment are ignored

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-Section-ToText'></a>
### ToText() `method`

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

<a name='M-IniSharpBox-Sections-#ctor'></a>
### #ctor() `constructor`

##### Summary

Contructor

##### Parameters

This constructor has no parameters.

<a name='P-IniSharpBox-Sections-Childs'></a>
### Childs `property`

##### Summary

List of section

<a name='P-IniSharpBox-Sections-Count'></a>
### Count `property`

##### Summary

Return number of item

<a name='P-IniSharpBox-Sections-GetNames'></a>
### GetNames `property`

##### Summary

Return list of Name of section

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

<a name='M-IniSharpBox-Sections-Merge-IniSharpBox-Sections,IniSharpBox-Sections,IniSharpBox-ALLOWDUPLICATE-'></a>
### Merge(first,second,duplicate) `method`

##### Summary

Return a merged Sections from 2 input Sections according to duplicate startegy

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [IniSharpBox.Sections](#T-IniSharpBox-Sections 'IniSharpBox.Sections') |  |
| second | [IniSharpBox.Sections](#T-IniSharpBox-Sections 'IniSharpBox.Sections') |  |
| duplicate | [IniSharpBox.ALLOWDUPLICATE](#T-IniSharpBox-ALLOWDUPLICATE 'IniSharpBox.ALLOWDUPLICATE') |  |

<a name='M-IniSharpBox-Sections-Remove-System-String-'></a>
### Remove(name) `method`

##### Summary

Return true if an item with name == Name exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-IniSharpBox-Sections-Remove-System-Int32-'></a>
### Remove(index) `method`

##### Summary

Return true if an item with index pass as argument exists and removing process succeed, otherwise false

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-IniSharpBox-Sections-ToSortedText'></a>
### ToSortedText() `method`

##### Summary

Return Sections stirngs

##### Returns



##### Parameters

This method has no parameters.

<a name='M-IniSharpBox-Sections-ToText'></a>
### ToText() `method`

##### Summary

Return Sections stirngs

##### Returns



##### Parameters

This method has no parameters.
