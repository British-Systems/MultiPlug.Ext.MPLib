# Creating a new .nupkg file

* Update AssemblyInfo.cs with new version numbers
* Build Release in Visual Studio
* Update MultiPlug.Ext.MPLib.nuspec with new version numbers
* Run nuget pack Nuget/MultiPlug.Ext.MPLib.nuspec
* Upload it to https://www.nuget.org/ manually