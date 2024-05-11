# HELLO EVERYONE.
## I'm Liu, a lover of program.

Now i will show you how to optimize original program about a simple calculator.Let's begin.

First we should learn some controls about layout.Here are some controls about "[Grid](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/controls/grid?view=netframeworkdesktop-4.8)"

* [Panel](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.panel?view=windowsdesktop-8.0)
  >Namespace:[System.Windows.Controls](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls?view=windowsdesktop-8.0)
  >
  >Assembly:PresentationFramework.dll
  >
  >为所有 Panel 元素提供基类。 使用 Panel 元素放置和排列 Windows Presentation Foundation (WPF) 应用程序中的子对象。
  >
  >Eample:
  >>以下示例将会演示如何使用 [Children](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.panel.children?view=windowsdesktop-8.0) 属性将两个[Button](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.button?view=windowsdesktop-8.0)对象添加到[StackPanel](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.stackpanel?view=windowsdesktop-8.0)容器

  >```XAML
  ><Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation">
  ><StackPanel>
  ><Button>Button 1</Button>
  >     <Button>Button 2</Button>
  >  </StackPanel>
  ></Page>
  >```c#
  >using System.Windows.Controls;
  >
  
* [Canvas](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.canvas?view=windowsdesktop-8.0)
  >Namespace:[System.Windows.Controls](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls?view=windowsdesktop-8.0)
  >
  >Assembly:PresentationFramework.dll
  >
  >定义一个区域，可在其中使用相对于 [Canvas](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.canvas?view=windowsdesktop-8.0) 区域的坐标以显式方式来定位子元素。
  >
  >```c#
  >public class Canvas : System.Windows.Controls.Panel
  
* [DockPanel](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.dockpanel?view=windowsdesktop-8.0)
    >Namespace:[System.Windows.Controls](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls?view=windowsdesktop-8.0)
    >
    >Assembly:PresentationFramework.dll
    >
    >定义一个区域，从中可以按相对位置水平或垂直排列各个子元素。
    >
    >```c#
    >public class DockPanel : System.Windows.Controls.Panel
    
 * [StackPanel](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.stackpanel?view=windowsdesktop-8.0)
    >Namespace:[System.Windows.Controls](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls?view=windowsdesktop-8.0)
    >
    >Assembly:PresentationFramework.dll
    >
    >将子元素排列成水平或垂直的一行。
    >
    >```c#
    >public class StackPanel : System.Windows.Controls.Panel, System.Windows.Controls.Primitives.IScrollInfo
    
 * [WrapPanel](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.wrappanel?view=windowsdesktop-8.0)
    >Namespace:[System.Windows.Controls](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls?view=windowsdesktop-8.0)
    >
    >Assembly:PresentationFramework.dll
    >
    >按从左到右的顺序位置定位子元素，在包含框的边缘处将内容切换到下一行。 后续排序按照从上至下或从右至左的顺序进行，具体取决于 Orientation 属性的值。
    >
    >```C#
    >public class WrapPanel : System.Windows.Controls.Panel
 * [Style](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.style?view=windowsdesktop-8.0)
   >Namespace: [System.Windows](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows?view=windowsdesktop-8.0)
   >
   >Assembly: PresentationFramework.dll
   >
   >在类型的不同实例之间共享属性、资源和事件处理程序.
   >
   >```c#
   >[System.Windows.Localizability(System.Windows.LocalizationCategory.Ignore)]
   >[System.Windows.Markup.ContentProperty("Setters")]
   >[System.Windows.Markup.DictionaryKeyProperty("TargetType")]
   >public class Style : System.Windows.Threading.DispatcherObject,
   >System.Windows.Markup.IAddChild, System.Windows.Markup.INameScope, 
   >System.Windows.Markup.IQueryAmbient
   >```
   >
   >Style元素常用形式如下：
   >```c#
   ><Style x:Key="键值" TargetTyp="控件类型" BasedOn="其他样式中定义的键值">
   >……
   ></Style>
   >```
   >
   >Samples:
   >>下面为 **XAML** 代码为 **Button** 定义了一个样式，自动应用所有 **Button** 元素.
   >```c#
   ><Window.Resources>
   >    <Style TargetType="Button">
   >        <Setter Property="FontSize" Value="18"/>
   >        <Setter Proprety="FontFamily" Value="Times New Roman"/>
   >        <Setter Property="FontWeight" Value="Bold"/>
   >    </Style>
   ></Window.Resources>
   >```
 * [Sourse](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/advanced/resources-wpf?view=netframeworkdesktop-4.8)
   >[Window.Resources](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/systems/xaml-resources-overview?view=netdesktop-7.0)
   >
   >资源是可以在应用中的不同位置重复使用的对象。 资源的示例包括画笔和样式。 本概述介绍如何使用 Extensible Application Markup Language (XAML) 中的资源。 你还可以使用代码创建和访问资源.
   >
   >[ResoursesDictionary](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.resourcedictionary?view=windowsdesktop-8.0)
   >Namespace: [System.Windows](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows?view=windowsdesktop-8.0)
   >
   >Assembly: PresentationFramework.dll
   >
   >资源字典
   >
   >在项目中添加一个新的“资源字典”，并设置属性，最后在控件中使用.
   >
   >* 在新建的 *Dictionary1.xaml* 文档中，会有如下代码：
   >
   >```c#
   ><ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
   >                     xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
   >    <SolidColorBrush x:Key="RedBrush" Color="Aqua"></SolidColorBrush>
   >    <FontWeight x:Key="fontWeight">Bold</FontWeight> //这两个属性是需要自己设置
   ></ResourceDictionary>
   >```
   >
   >* 在 *App.xaml* 中完成资源的合并，代码如下：
   >
   >```c#
   ><Application x:Class="Brush.App"
   >              xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
   >              xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
   >              xmlns:local="clr-namespace:Brush"
   >              StartupUri="MainWindow.xaml">
   >       <Application.Resources>
   >           <ResourceDictionary>
   >               <ResourceDictionary.MergedDictionaries>
   >                   <ResourceDictionary Source="Dictionary1.xaml"/>
   >               </ResourceDictionary.MergedDictionaries>
   >           </ResourceDictionary>
   >       </Application.Resources>
   ></Application>
   >```
   >
   >* 最后在 *MainWindow.xaml* 窗口中对资源进行使用，代码如下：
   >
   >```c#
   ><StackPanel>
   >    <Button Background="{StaticResource RedBrush}" FontSize="14" Content="静态资源"/>
   >    <Button Background="{StaticResource RedBrush}" FontSize="14" Content="动态资源"/>
   >    <Button FontSize="14" FontWeight="{StaticResource fontWeight}" Content="修改颜色"/>
   ></StackPanel>
   >```
#### We just need to learn these controls about layout,then we can optimize our original program of calculator.

********

>>Please pay attention:
>>
>>If you have some questions about this. Please contect me with email.
>>
>>Email:luc444175@gmail.com
>>
>>This is the [official document](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/controls/?view=netframeworkdesktop-4.8) about controls.
     
     




  
