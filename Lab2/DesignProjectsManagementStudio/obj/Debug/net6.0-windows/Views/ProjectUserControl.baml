   M S B A M L   `   `   `  ????Y  UDesignProjectsManagementStudio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:DesignProjectsManagementStudio.Views$DesignProjectsManagementStudio.Views  5      e7clr-namespace:DesignProjectsManagementStudio.Converters)DesignProjectsManagementStudio.Converters  5      =    7DesignProjectsManagementStudio.Views.ProjectUserControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:DesignProjectsManagementStudio.Views     5      M	Converter7clr-namespace:DesignProjectsManagementStudio.Converters     5        ? 	Resources  5
      >   8DesignProjectsManagementStudio.Converters.ImageConverter   my:ImageConverter??%   &	          5   
   6#   5      .??5      ?  J? RenderTransformOrigin$ 0.569,0.441&?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ProjectsDataGrid??5      $	??277??6S   $	??500??6_   $	??Top=?5      $
??Left=?6+   $
??Auto??6F      AutoGenerateColumns$ False??6T   $??	-1,34,0,0q?6p   ??5   -   ??  ?? Path$ Projects? ?? SelectedItem 5      ?? $ SelectedProject? ?? Mode$ TwoWay=?   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True??6%   	   Header$	 Project Name??67   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6M   ?? *Name+  5      $
 True??6%   $	 
Start Date??67   
 6K   ?? *	StartDate+  5      $
 True??6%   $	 End Date??67   
 6I   ?? *	EndDate+4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 True??6)   $	 Project Type??6;      Width5  /System.Windows.Controls.DataGridLengthConverter$ 48 6Q      CellTemplate 5      ?? 5      .R?5      ?? $??48??6$   $??48??6/   ??6;   ?? *Type+ ?? 	Converter# [  5      5      5      ?? 5    
   -   5         ??Name$ NewNameTextBox??5       $
??Left=?6*    ?? TextWrapping$
 Wrap=?6E   $	??158??6Z   ???	#FFD28C8C$??642,0,0,317q?6}   $??42??6?   $??Bottom=?6?   ?? 5!   
   $??Enter new name:??6   $
??Left=?6*   $	??158??6F   $??642,0,0,364q?6R   $??36??6g   $??Bottom=?6s   ?? 5"   
   -   5         ??Name$ ConfirmNewNameButton??5"      $??Confirm??6/   ???	#FF5292B1$??642,0,0,400q?6|   $ 0.503,1.741&?6?   $
??Left=?6?   $	??158??6?   $??50??6?   $??Bottom=?6?   ?? 5#   
   -   5        $+ %SetCurrentDateOnSelectedProjectButton??5#   @   $??End project!??6o   #??? ??6?   $??50??6?   $	??Top=?6?   $??642,133,0,0q?6  ??6   ?? $ SetCurrentDateCommand?6  5$      5%      