   M S B A M L   `   `   `  ����  HerbalAnalysis    HerbalAnalysis.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   p lXceed.Wpf.AvalonDock.Themes.Expression, Version=2.0.2000.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4^ ZXceed.Wpf.AvalonDock, Version=2.0.2000.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4;avalon,http://schemas.xceed.com/wpf/xaml/avalondock   5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � WindowStartupLocation$ Manual=�5   	    � WindowStyle$ SingleBorderWindow=�6(    � WindowState$ 	Maximized=�6�    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.New��5      6;   .��5
      �  � UseLayoutRounding .  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   o� -   5        $��mainMenu��5      $��0��6   $��14(�6,   ���	#FFEEF5FD.@�5      m� -   5        $��menuItemFile��5      $��
文件(_F)��6+   .@�5      m� -   5        $��menuItemNew��5       m� Command$	 New��6.   m� 5      -   5        $��menuItemOpen��5      �� 5      m� 5      -   5        $��menuItemAdd��5      �� 5      m� 5      -   5        $��menuItemClose��5      �� 5      m� 5      -	   5        $��menuItemRecentProject��5      5      �� 5       m� 5!      -
   5        $��menuItemExit��5!      5"      m� 5#      -   5        $��menuItemEdit��5#      $��
编辑(_E)��6+   .@�5$      m� -   5        $��menuItemUndo��5$      m� 5%      -   5        $��menuItemCut��5%      m� 5&      -   5        $��menuItemCopy��5&      m� 5'      -   5        $��menuItemPaste��5'      �� 5(      m� 5)      -   5        $��menuItemDelete��5)      5*      m� 5+      -   5        $��menuItemView��5+      $��
视图(_V)��6+   .@�5,      m� -   5        $��menuItemProjResManager��5,      m� 5-      -   5        $��menuItemProjAttrPage��5-      5.      m� 5/      -   5        $��menuItemTools��5/      $��
工具(_T)��6,   51      m� 52      -   5        $��menuItemAbout��52      $��
关于(_A)��6,   54      55      c� 56   
   -   5        $��mainToolbar��56      $��1��6%   .@�57      �� .��6   Open6   58      � 59   
    . $��2��6(   .+�5;      )  #Xceed.Wpf.AvalonDock.DockingManager  	   Theme	 5<      5  /Xceed.Wpf.AvalonDock.Themes.ExpressionDarkTheme  5=      
   Layout.
 5?      ,  &Xceed.Wpf.AvalonDock.Layout.LayoutRoot  5A      5B      �� 5C      -   5        $��20��5C      69   5D      5E      5F      