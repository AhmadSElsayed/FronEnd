   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��85 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��End Date��6   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ endDate��5   �      SelectedDateFormat$ Short=�6�   $��1��6�   $��0��6�      SelectedDate 6   ��  �� Path$ EndDate� �� Mode$ TwoWay=� �� ValidatesOnDataErrors . "	 �� ValidatesOnNotifyDataErrors	 . 
 �� ValidatesOnExceptions
 . 6�   �� 5   
   $��Season Name��6   $��1��6&   �� 5   
   -   5         ��Name$ 
seasonName��5   �   $��1��6�   $��1��6�   ��6   �� $ 
SeasonName�$ TwoWay=� . 	 . 
 . 6�   �� 5   
   $��
Start Date��6   $��2��6%     5   
   -   5        $ 	startDate��5   �   $ Short=�6�   $��1��6�   $��2��6�    6   �� $ 	StartDate�$ TwoWay=� . 	 . 
 . 6�   5      5      