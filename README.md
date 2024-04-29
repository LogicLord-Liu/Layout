# HELLO EVERYONE.
## I'm Liu, a lover of program.

Now i will show you how to optimize original program about a simple calculator.Let's begin.

First we should learn some controls about layout.Here are some controls about "[Grid](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/controls/grid?view=netframeworkdesktop-4.8)"

* [Panel][1] Class:
  >Namespace:[System.Windows.Controls](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls?view=windowsdesktop-8.0)
  >
  >Assembly:PresentationFramework.dll
  >
  >为所有 Panel 元素提供基类。 使用 Panel 元素放置和排列 Windows Presentation Foundation (WPF) 应用程序中的子对象。
  >
  >Eample:
  >>以下示例将会演示如何使用 [Children](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.panel.children?view=windowsdesktop-8.0) 属性将两 [Button](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.button?view=windowsdesktop-8.0)个 [StackPanel](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.controls.stackpanel?view=windowsdesktop-8.0)对象添加到。

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
    
#### We just need to learn these controls about layout,then we can optimize our original program of calculator.

********

>>Please pay attention:
>>
>>If you have some questions about this. Please contect me with email.
>>
>>Email:luc444175@gmail.com
>>
>>This is the [official document](https://learn.microsoft.com/zh-cn/dotnet/desktop/wpf/controls/?view=netframeworkdesktop-4.8) about controls.
     
     




  
