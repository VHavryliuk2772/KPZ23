   M S B A M L   `   `   `  ????Y  UDesignProjectsManagementStudio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:DesignProjectsManagementStudio.Views$DesignProjectsManagementStudio.Views  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      >    8DesignProjectsManagementStudio.Views.EmployeeUserControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:DesignProjectsManagementStudio.Views     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      .??5      ?   ? ColumnDefinitions  5   
   ?? 5      $	??300 ?6   5      ?? 5      $	??300 ?6   5      .+?5   
   ?? $??0??6   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesDataGrid??5      $??50??6Y   $	??500??6d   $	??Top=?5      $
??Left=?6+   $
??Auto??6F      AutoGenerateColumns$ False??6T   $??	-1,34,0,0q?6p   ??5   2   ??  ?? Path$ 	Employees? ?? SelectedItem 5      ?? $ SelectedEmployee? ?? Mode$ TwoWay=?   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True??6)      Header$ 
First Name??6;   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6O   ?? *	FirstName+  5      $
 True??6)   $ 	Last Name??6;   	 6N   ?? *
LastName+??5      ?? 5      
 ?? 
TargetType"
  6    ?? Triggers 5      :? 5       :? RoutedEvent$ 
MouseEnter??6+   [?5   "   ?? 5    &   .??5!   *   ?? .??5"   .   W?  g? Duration$ 	0:0:0:0.5D?6>    ?? TargetProperty$ Width?6S   	 W? To 1476u   5#   +   5$   '   5&      :? 5'      $ 
MouseLeave??6+   [?5(   "   ?? 5)   &   .??5*   *   ?? .??5+   .   W? $ 	0:0:0:0.5D?6>   $ Width?6S    506u   5,   +   5-   '   5/      51      53      54      ?? 55   
   $??1??6   .+?56        -   5        $ EmployeeProjectsDataGrid??56      $
??Auto??57      $	??500??6    $	??Top=?6/   $
??Left=?6G   $ False??6b   ??56   9   ?? $ SelectedEmployeeProjects? 58        59      $
 True??6)   $
 Name??6;   	 6I   ?? *Name+  5:      $
 True??6)   $ 
Start Date??6;   	 6O   ?? *	StartDate+  5;      $
 True??6)   $ End Date??6;   	 6M   ?? *	EndDate+.  (System.Windows.Interactivity.Interaction   Triggers 5>      /  )System.Windows.Interactivity.EventTrigger  5?         	EventName$ SelectionChanged??6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5@      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   ?? *&$SelectCurrentEmployeeProjectsCommand+5A      5C      5D      5E      5F      