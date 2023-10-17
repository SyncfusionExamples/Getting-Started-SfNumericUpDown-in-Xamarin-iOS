# Getting Started with Xamarin NumericUpDown (SfNumericUpDown

This section provides overview for working with Essential SfNumericUpDown for Xamarin.Forms. You can walk through the entire process of creating a SfNumericUpDown.

# Assembly deployment
After installing Essential Studio for Xamarin, you can find all the required assemblies in the installation folders, {Syncfusion Essential Studio Installed location} \Essential Studio\{Version #}\Xamarin\lib.

# Adding SfNumericUpDown reference
You can add SfNumericUpDown reference using one of the following methods:

## Method 1: Adding SfNumericUpDown reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfNumericUpDown to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.SfNumericUpDown, and then install it.

## Method 2: Adding SfNumericUpDown reference from toolbox

Syncfusion also provides Xamarin Toolbox. Using this toolbox, you can drag the SfNumericUpDown control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

## Method 3: Adding SfNumericUpDown assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

# iOS
To launch SfNumericUpDown in iOS, need to create an instance of SfNumericUpDownRenderer in FinishedLaunching overridden method of AppDelegate class in iOS Project as shown below.

**[C#]**
```
public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
	global::Xamarin.Forms.Forms.Init();

	SfNumericUpDownRenderer.Init();

	LoadApplication(new App());

	return base.FinishedLaunching(app, options);
   
}
```
# Create a Simple SfNumericUpDown
The SfNumericUpDown control can be configured entirely in C# code or by using the XAML markup. The following steps explain how to create a SfNumericUpDown and configure its elements.

*	Adding namespace for the added assemblies.

**[XAML]**
```
<xmlns:numeric="clr-namespace:Syncfusion.SfNumericUpDown.XForms;assembly=Syncfusion.SfNumericUpDown.XForms"/>
```
**[C#]**
```
using Syncfusion.SfNumericUpDown.XForms;
```
*	Now add the SfNumericUpDown control with a required optimal name by using the included namespace.

**[XAML]**
```
<numeric:SfNumericUpDown/>
```
**[C#]**

```
SfNumericUpDown numericUpDown=new SfNumericUpDown();
this.Content = numericUpDown;
```
# Set value in SfNumericUpDown
The SfNumericUpDown control display value can be set using the Value property.

**[XAML]**
```
<numeric:SfNumericUpDown Value="5"/>
```
**[C#]**
```
SfNumericUpDown numericUpDown=new SfNumericUpDown();
numericUpDown.Value= 5;
this.Content = numericUpDown;
```
## How to run this application?

To run this application, you need to first clone the Getting-Started-SfNumericUpDown-in-Xamarin-iOS repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.