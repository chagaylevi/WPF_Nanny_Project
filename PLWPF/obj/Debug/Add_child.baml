   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.Add_child   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  הוספת ילד��5	   	   $	��320��6   $	��300��6(   .��5      �    	gridStyle#���   6    � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��220* �6   �� 5      $	��25* �6   .+�5   
   � -   5         �Name$ grid1��5      $��0,52,0,3q�6   $��2��60    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6     5"      �� 5#      $
��Auto �6#   $	��134��60   �� 5$      $
��Auto �6#   $	��158��60   .+�5&      �� $��Center=�6   $��0��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��1��6h   $��:תאריך לידה��6x   $��26��6�   $��72��6�   (  "System.Windows.Controls.DatePicker  5'      -   5          Name$ date_of_birthDatePicker��5'      $��Bottom=�6:   $��0��6�   $��	0,0,3.2,4q�6�   $��Right=�6�   $��0��6�   $��24��6  $	��102��6     SelectedDate 6U   �� *date_of_birth+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . ��5(      �� 5)      	 �� 
TargetType"	  6   
 �� Triggers
 5*      P� 5+       P� Property �@ SelectedDate P� Value$  X�6>   . �5,   "   ��  �� Property � �� �� Value
 �  ��6@   5-      5/      51      �� 52      $��Center=�6   $��2��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��1��6h   $��:ת.ז של הילד��6x   $��26��6�   $��74��6�   �� 53      -   5         ��Name$ id_childTextBox��53      $	��120��6/   $��Center=�6;   $��2��6�   $��3,4,0,4q�6�   $��24��6�   $��Right=�6�   $��0��6�   ��6V   �� *
id_child+$ TwoWay=� .  . .��6  ��54      �� 55      "	 ��6   
 56      P� 57       � ��$  ��66   . �58   "   ��  � ��
 �  ��6@   59      5;      .��5<   !   5=      �� 5>      $��Center=�6   $��3��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��1��6h   $��:ת.ז של האם��6x   $��26��6�   $��75��6�   �� 5?      -   5        $ id_motherTextBox��5?      $	��120��60   $��Center=�6<   $��3��6�   $��3,4,0,4q�6�   $��24��6�   $��Right=�6�   $��0��6�   ��6W   �� *	id_mother+$ TwoWay=� .  . .��6  ��5@      �� 5A      "	 ��6   
 5B      P� 5C       � ��$  ��66   . �5D   "   ��  � ��
 �  ��6@   5E      5G      .��5H   !   5I      �� 5J      $��Center=�6   $��4��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��1��6h   $��:שם הילד��6x   $��26��6�   $��57��6�   �� 5K      -   5        $ nameTextBox��5K      $	��120��6+   $��Center=�67   $��4��6�   $��3,4,0,4q�6�   $��24��6�   $��Right=�6�   $��0��6�   ��6R   �� *name+$ TwoWay=� .  . 6�   �� 5L      $��Center=�6   $��5��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��1��6h   $4��.?האם קיימים צרכים מיוחדים��6x   $��26��6�   $	��155��6�   �� 5M      -   5         ��Name$ special_needsCheckBox��5M      $��Center=�66   $��5��6Q   $��0,8,3,8q�6^   $��Right=�6�   $��0��6�   $�� ��6  $��16��6  $��20��6   d� 	IsChecked 6o   �� *special_needs+$ TwoWay=� .  . 6  �� 5N      $��Center=�6   $��6��6/   $��3,3,0,3q�6<   $
��Left=�6M   $��1��6h   $ ��:צרכים מיוחדים��6x   $��26��6�   $��88��6�   �� 5O      -   5        $ special_needsTextBox��5O      $	��120��64   $��Center=�6@   $��6��6	  $��3,4,0,4q�6  $��24��6'  $��Right=�63  $��0��6O  {�6[   ��  �� ElementName$ special_needsCheckBox�� �� Path$ 	IsChecked���6�   �� *Special_needs+$ TwoWay=� .  . 6O  5P      �� 5Q   
   -   5         ��Name$ label��5Q      $1��+:אנא מלאי את השדות הבאים��6   $��Right=�6B   $��	0,15,15,0q�6^   $	��Top=�6q   $��15(�6�   $
��auto��6�   $��2��6�   �� 5R   
   -	   5         ��Name$	 add��5R      $��
הוספה��6   $��1��6.   $��5,0,5,0q�6;   $��15(�6L   ��5S      �� 5T      
 5U      �� 5V       �� Binding 6&   �� $ date_of_birthDatePicker��$ 
DatePicker� �� Value 
01/01/00016o   .a�5W      ��  � {� .  6A   5X      �� 5Y       6&   �� $ id_childTextBox��$
 Text�  6a   .a�5Z      ��  � {� .  6A   5[      �� 5\       6&   �� $ id_motherTextBox��$
 Text�  6b   .a�5]      ��  � {� .  6A   5^      5`      5b      �� 5c   
   -
   5        $ update��5c      $��
עדכון��6!   $��15(�6H   $��1��6V   $��5,0,5,0q�6f   $��1��6w   5d      5e      