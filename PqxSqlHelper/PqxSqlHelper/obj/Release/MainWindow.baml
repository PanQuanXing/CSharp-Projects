   M S B A M L   `   `   `  ���� U  QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35[<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkitMicrosoft.Windows.Controls  M ISystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089M3clr-namespace:System.ComponentModel;assembly=SystemSystem.ComponentModel  PqxSqlHelper   PqxSqlHelper.MainWindow   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      8x,http://schemas.microsoft.com/winfx/2006/xaml    Ntoolkit<clr-namespace:Microsoft.Windows.Controls;assembly=WPFToolkit    @cm3clr-namespace:System.ComponentModel;assembly=System    -     � Title$3  -数据库查询助手（作者：潘全星）��$	��600��$	��800�� � WindowStartupLocation$ CenterScreen=� � Icon$ searchSqlHelper.ico�� � 	Resources ,  &System.ComponentModel.BackgroundWorker   backgroundWorker1!   WorkerSupportsCancellation��%   &	          -    . .���  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ���  � ColumnDefinitions �� $��4* ��� $��2* ��� $��3* �.+��� $��	选择表��$��0��$��3��$��0��$��1q����	#FFBCBCBC.��� $��1q� �� $��2* ��� $��5* ��� $��2* ��� $��5* �.+��� $��0��$��	类型：��$��Center=�$��Right=��� -   $��typeComboBox��$��1�� �� 
IsEditable . 
������� �� 
IsReadOnly . 	 �� SelectedIndex	 �� *	TYPEINDEX+
 �� Mode$
 TwoWay=��� $��2��$��	表名：��$��Center=�$��Right=��� -   $��tableItemComboBox��$��3�� . 
������� . 	 �� *
TABLEINDEX+$
 TwoWay=��� $��选择字段��$��1��$��0��$��3��$��1q����	#FFBCBCBC.��� $��1q� �� $��2* ��� $��5* �.+��� $��0��$��	字段：��$��Center=�$��Right=��� -   $��fieldComboBox��$��1�� . 
������� . ���� �� $��查找��$��2��$��0��$��3��$��1q����	#FFBCBCBC.��� $��1q� �� $��4* ��� $��* �.+��� -   $��fieldTextBox��$��0��$��1q�
��������� -   $��searchButton��$��1��$��2q�$��搜索�� �� 	IsDefault . �� -   $��tipsTextBlock��$��0��$��2��$��3��$��Center=�
���  ���� -	   $��setttingButton��$��3��$��2��$��数据库参数设置��$��4q�)   #Microsoft.Windows.Controls.DataGrid  -
     Name$ dataGrid��$��0��$��3��$��5��   AutoGenerateColumns .    
IsReadOnly . $��1q�