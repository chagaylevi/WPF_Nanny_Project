   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  ראשי��5   	   $	��350��6   $	��525��6#   .��5
      �    	gridStyle#���   6    � ColumnDefinitions 5   
   �� 5      $
��272* �6   �� 5      $
��245* �6    � RowDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Medium"�6   $C��=ברוכים הבאים לתוכנית מטפלת לכל אם��63   $��25(�6`   $��Center=�6n   $��
35,33,35,0q�6�   $	��Top=�6�   $��43��6�   $
��auto��6�   $��2��6�   �� 5   
   -   5        $ label1��5      $2��,:אנא בחרי באחת האפשרויות��6    $��20(�6C   $��Center=�6Q   $	��Top=�6n   $��120,96,120,0q�6�   $
��auto��6�   $��SemiBold"�6�   $��2��6�   $��37��6�   �� 5   
   -   5         ��Name$ listBox_nanny��5      $	��Top=�6)   $��90��6A   
������$��Right=�6e   $��12(�6�   $y�	Collapsed=�6�   $��1��6�   $��0,0,0,0q�6�   $	��100��6  $��Right=�6  $��0��6q  �� 5   
   -   5        $ listBox_mother��5      
����+��$��Right=�6B   $��12(�6�   $y�	Collapsed=�6�   $	��149��6�   $��1��6�   $	��Top=�6�   $	��120��6  $��Right=�6  $��0��62  6B  �� 5   
   $��1��6   $��1��6%   .+�5      �� -   5         ��Name$ button_nanny��5      $��◄    מטפלת      ��6+   $��Guttman Yad-Brush)�6F   
������$��23(�6�   $��45��6�   �� 5      -   5        $ button_mother��5      $��Guttman Yad-Brush)�6,   $��◄      אמא       ��6�   
����+��$��23(�6�   $��45��6�   �� 5      -   5        $ button_optiones��5      $��Guttman Yad-Brush)�6.   $'��!◄ אפשרויות נוספות��6�   
�������$��23(�6�   $��45��6�   5      �� 5   
   -   5        $ listBox_options��5      $
��auto��6+   
�������$y�	Collapsed=�6�   $��Right=�6�   $��0,60,0,0q�6�   $��1��6�   $	��Top=�6�   $��Right=�6
  $	��150��6-  69  5      5      