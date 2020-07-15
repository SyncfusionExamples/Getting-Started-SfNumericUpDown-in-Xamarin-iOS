# Getting started of SfNumericUpDown in Xamarin.iOS

This section provides overview for working with Essential NumericUpDown for Xamarin.iOS. You can walk through the entire process of creating a SfNumericUpDown.

Referencing Essential Studio Components in Your Solution
After installing Essential Studio for Xamarin, you can find all the required assemblies in the installation folders, typically:

{Syncfusion Installed location}\Essential Studio{version number}\lib

**NOTE**

Assemblies are available in unzipped package location in Mac

and below assembly reference to the iOS unified project.

iOS-unifed\Syncfusion.SfNumericUpDown.iOS.dll

## Add SfNumericUpDown
The SfNumericUpDown control configured entirely in C# code. The following steps explain on how to create a SfNumericUpDown and configure its elements,

Adding namespace for the added assemblies.
```
using Syncfusion.SfNumericUpDown.iOS;
```
Now add the SfNumericUpDown control with a required optimal name by using the included namespace.

[C#]

```
SfNumericUpDown numeric = new SfNumericUpDown()
{
	
	Frame = new CGRect(10, 50, 350, 40),
};

this.Add(numeric);
```

## Set Value
The SfNumericUpDown control display value can be set using Value property.


[C#]

```
numeric.Value = 100;
```
