   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.Add_mother   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  הוספת אמא��5
   	   $	��500��6   $	��600��6(   .��5      �    	gridStyle#���   6    � ColumnDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��94* �6   �� 5      $	��94* �6   �� 5      $	��96* �6   �� 5      $
��178* �6   �� 5      $
��107* �6    � RowDefinitions 5   
   �� 5      $	��80* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��35* �6   �� 5      $	��70* �6   .+�5    
   �� -   5         ��Name$ button��5       $��
הוספה��6!   $��15,15,32,15q�61   $��22(�6F   $��8��6T   $��3��6v   ��5!      �� 5"       �� Triggers 5#      �� 5$       �� Binding 6&   ��  �� ElementName$ 
id_textBox�� �� Path$
 Text� �� Value  6\   .a�5%      �� 	 �� Property	 � {�
 �� Value
 .  6A   5&      �� 5'       6&   �� $ textBox1��$
 Text�  6Z   .a�5(      �� 	 � {�
 .  6A   5)      �� 5*       6&   �� $ textBox2��$
 Text�  6Z   .a�5+      �� 	 � {�
 .  6A   5,      �� 5-       6&   �� $ textBox3��$
 Text�  6Z   .a�5.      �� 	 � {�
 .  6A   5/      �� 50       6&   �� $ textBox4��$
 Text�  6Z   .a�51      �� 	 � {�
 .  6A   52      54      56      �� 57   
   -   5        $ button1��57      $��הוספת ילד��6"   $��102,15,15,15q�66   $��22(�6L   $��4��6Z   $��8��6j   $��2��6w   ��58      �� 59       5:      �� 5;       6&   �� $ 
id_textBox��$
 Text�  6\   .a�5<      �� 	 � {�
 .  6A   5=      �� 5>       6&   �� $ textBox1��$
 Text�  6Z   .a�5?      �� 	 � {�
 .  6A   5@      �� 5A       6&   �� $ textBox2��$
 Text�  6Z   .a�5B      �� 	 � {�
 .  6A   5C      �� 5D       6&   �� $ textBox3��$
 Text�  6Z   .a�5E      �� 	 � {�
 .  6A   5F      �� 5G       6&   �� $ textBox4��$
 Text�  6Z   .a�5H      �� 	 � {�
 .  6A   5I      5K      5M      �� 5N   
   -   5         ��Name$ label��5N      $��מספר ת.ז��6   $��5��62   $
��Left=�6B   $��0,70,0,0q�6]   $	��Top=�6o   $��26��6�   $��59��6�   $��2��6�   �� 5O   
   -   5        $ label1��5O      $��שם פרטי��6    $��5��62   $
��Left=�6B   $��0,9,0,0q�6]   $	��Top=�6n   $��26��6�   $��57��6�   $��1��6�   �� 5P   
   -   5        $ label2��5P      $��שם משפחה��6    $��5��63   $
��Left=�6C   $��0,39,0,0q�6^   $	��Top=�6p   $��26��6�   $��72��6�   $��1��6�   $��2��6�   �� 5Q   
   -   5        $ label3��5Q      $��מס' פלאפון��6    $��5��65   $
��Left=�6E   $��0,26,0,0q�6`   $	��Top=�6r   $��26��6�   $��68��6�   $��2��6�   $��2��6�   �� 5R   
   -   5        $ label4��5R      $��
כתובת��6    $��5��60   $
��Left=�6@   $��0,18,0,0q�6[   $��26��6m   $	��Top=�6y   $��44��6�   $��3��6�   $��2��6�   �� 5S   
   -   5        $ label5��5S      $$��איזור חיפוש רצוי��6    $��5��6;   $
��Left=�6K   $��0,10,0,0q�6f   $	��Top=�6x   $��26��6�   $��93��6�   $��4��6�   �� 5T   
   -	   5        $ label6��5T      $��מספר ילדים��6    $��5��65   $
��Left=�6E   $��0,40,0,0q�6`   $	��Top=�6r   $��26��6�   $��71��6�   $��4��6�   $��2��6�   �� 5U   
   -
   5        $ label7��5U      $��אם חד הורית��6    $��5��66   $
��Left=�6F   $��0,28.443,0,0q�6a   $	��Top=�6w   $��26��6�   $��76��6�   $��5��6�   $��2��6�   �� 5V   
   -   5        $ label8��5V      $��
הערות��6    $��5��60   $
��Left=�6@   $��0,13.886,0,0q�6[   $	��Top=�6r   $��26��6�   $��44��6�   $��6��6�   �� 5W   
   -   5         ��Name$ 
id_textBox��5W      $��Center=�6&   $��Right=�6J   $��4��6f   $��23��6v   $��0,70,0,0q�6�   $	��Top=�6�   $	��130��6�   ��6�   �� *id+.��6�   ��5X      �� 5Y       �� 
TargetType" ��6    5Z      P� 5[       P� Property � �� P� Value$  ��62   . �5\      �� 	 � ��

 �  ��6<   5]      5_      .��5`      5a      �� 5b   
   -   5        $ textBox1��5b      $��Right=�6$   $��Right=�6G   $��4��6c   $��23��6s   $��0,12,0,0q�6   $	��Top=�6�   $	��130��6�   $��1��6�   ��6�   �� *	firstName+.��6�   ��5c      �� 5d      " ��6    5e      P� 5f       � ��$  ��62   . �5g      �� 	 � ��

 �  ��6<   5h      5j      .��5k      5l      �� 5m   
   -   5        $ textBox2��5m      $��Right=�6$   $��Right=�6G   $��4��6c   $��23��6s   $	��Top=�6�   $	��130��6�   $��2��6�   ��6   �� *
lastName+.��6�   ��5n      �� 5o      " ��6    5p      P� 5q       � ��$  ��62   . �5r      �� 	 � ��

 �  ��6<   5s      5u      .��5v      5w      �� 5x   
   -   5        $ textBox3��5x      $��Center=�6$   $��Right=�6k   $��4��6�   $��23��6�   $��0,29,0,0q�6�   $	��Top=�6�   $	��130��6�   $��2��6�   $��2��6�   ��6�   �� *phone+.��6  ��5y      �� 5z      " ��6    5{      P� 5|       � ��$  ��62   . �5}      �� 	 � ��

 �  ��6<   5~      5�      .��5�      5�      �� 5�   
   -   5        $ textBox4��5�      $��Right=�6$   $��Right=�6G   $��4��6c   $��23��6s   $��0,20,0,0q�6   $	��Top=�6�   $	��130��6�   $��3��6�   $��2��6�   ��6�   �� *	address+.��6�   ��5�      �� 5�      " ��6    5�      P� 5�       � ��$  ��62   . �5�      �� 	 � ��

 �  ��6<   5�      5�      .��5�      5�      �� 5�   
   -   5        $ textBox5��5�      $��Right=�6$   $��Right=�6G   $��4��6c   $��23��6s   $��0,12,0,0q�6   $	��Top=�6�   $	��130��6�   $��4��6�   ��6�   �� *search_area+6�   �� 5�   
   -   5        $ textBox6��5�      $��Right=�6$   $��Right=�6G   $��4��6c   $��54��6s   $��0,18.886,0,0q�6   $	��Top=�6�   $	��130��6�   $��6��6�   $��2��6�   ��6�   �� *
comments+6�   �� 5�   
   -   5        $ textBox7��5�      $��4��6$   $��Center=�64   $��Right=�6X   $��23��6t   $��0,4.443,0,0q�6�   $��5��6�   $	��Top=�6�   $	��130��6�   ��6�   �� *count_of_children+6�   �� 5�   
   -   5         ��Name$ checkBox��5�      $�� ��6%   $��Right=�60   $��4��6L    �� 
LineHeight$ 23��6\   $��0,34.443,0,0q�6�   $	��Top=�6�   $��5��6�   $��2��6�   $��22��6�   $��20��6�    d� 	IsChecked 6r   �� *signle_mother+6�   �� 5�   
   -   5         ��Name$ 	textBlock��5�      $��3��6'   $��Right=�67   $��	0,25,15,0q�6S   $
��Wrap=�6f   $1��+:אנא מלאי את השדות הבאים��6z   $��22(�6�   $	��Top=�6�   $	��309��6�   $��27��6�   $��3��6�   �� 5�   
   -   5        $ label9��5�      $��יום בשבוע��6    $
��Left=�64   $��7,57,0,7q�6O   $��Center=�6a   $��3��6|   $��15(�6�   $��0��6�   $��30��6�   $��74��6�   �� 5�   
   -   5        $ label10��5�      $��משעה��6!   $
��Left=�60   $��	10,57,0,7q�6K   $��Center=�6^   $��2��6y   $��30��6�   $��15(�6�   $��0��6�   $��51��6�   �� 5�   
   -   5        $ label11��5�      $��עד שעה��6!   $
��Left=�62   $��Center=�6M   $��	10,57,0,7q�6h   $��30��6{   $��0��6�   $��15(�6�   $��62��6�   $��1��6�   �� 5�   
   -   5        $ 	checkBox1��5�      $��   ראשון��6&   $
��Left=�69   $��	13,12,0,0q�6T   $��1��6g   $	��Top=�6t   $��3��6�   $��15��6�   $��72��6�    6�   �� *work_days[0]+6�   �� 5�   
   -   5        $ 	checkBox2��5�      $��	   שני��6&   $
��Left=�69   $��	13,11,0,0q�6T   $��2��6g   $	��Top=�6t   $��3��6�   $��15��6�   $��72��6�    6�   �� *work_days[1]+6�   �� 5�   
   -   5        $ 	checkBox3��5�      $��   שלישי��6&   $
��Left=�69   $��	13,11,0,0q�6T   $��3��6g   $	��Top=�6t   $��3��6�   $��15��6�   $��72��6�    6�   �� *work_days[2]+6�   �� 5�   
   -   5        $ 	checkBox4��5�      $��   רביעי��6&   $
��Left=�69   $��13,11.443,0,0q�6T   $��4��6k   $	��Top=�6x   $��3��6�   $��15��6�   $��72��6�    6�   �� *work_days[3]+6�   �� 5�   
   -   5        $ 	checkBox5��5�      $��   חמישי��6&   $
��Left=�69   $��13,11.886,0,0q�6T   $��5��6k   $	��Top=�6x   $��3��6�   $��15��6�   $��72��6�    6�   �� *work_days[4]+6�   �� 5�   
   -   5        $ 	checkBox6��5�      $��   שישי��6&   $
��Left=�69   $��13,12.329,0,0q�6T   $��6��6k   $	��Top=�6x   $��3��6�   $��15��6�   $��72��6�    6�   �� *work_days[5]+6�   �� 5�   
   -   5        $
 end1��5�      $��1q�6    $��1��6,    �� TextWrapping$
 Wrap=�69   $��Center=�6�   $��16(�6�   $��5,9,5,10q�6�   $��1��6�   ��6M   �� *end_hours[0]+ �� StringFormat$ hh\:mm��{�6�   �� $ 	checkBox1��$ 	IsChecked�6�   �� 5�   
   -    5        $
 end2��5�      $��1q�6    $��2��6,   $
 Wrap=�69   $��Center=�6�   $��16(�6�   $��5,8,5,10q�6�   $��1��6   ��6M   �� *end_hours[1]+$ hh\:mm��{�6�   �� $ 	checkBox2��$ 	IsChecked�6   �� 5�   
   -!   5        $
 end3��5�      $��1q�6    $��3��6,   $
 Wrap=�69   $��Center=�6�   $��16(�6�   $��5,9,5,10.557q�6�   $��1��6  ��6M   �� *end_hours[2]+$ hh\:mm��{�6�   �� $ 	checkBox3��$ 	IsChecked�6  �� 5�   
   -"   5        $
 end4��5�      $��1q�6    $��4��6,   $
 Wrap=�69   $��Center=�6�   $��16(�6�   $��5,8.443,5,9.114q�6�   $��1��6  ��6M   �� *end_hours[3]+$ hh\:mm��{�6�   �� $ 	checkBox4��$ 	IsChecked�6  �� 5�   
   -#   5        $
 end5��5�      $��1q�6    $��5��6,   $
 Wrap=�69   $��Center=�6�   $��16(�6�   $��5,8.886,5,8.671q�6�   $��1��6  ��6M   �� *end_hours[4]+$ hh\:mm��{�6�   �� $ 	checkBox5��$ 	IsChecked�6  �� 5�   
   -$   5        $
 end6��5�      $��1q�6    $��6��6,   $
 Wrap=�69   $��Center=�6�   $��16(�6�   $��5,9.329,5,8.671q�6�   $��1��6  ��6M   �� *end_hours[5]+$ hh\:mm��{�6�   �� $ 	checkBox6��$ 	IsChecked�6  �� 5�   
   -%   5        $ start1��5�      $��1q�6"   $��2��6.   $��1��6>   $��Center=�6�   $��16(�6�   $��5,10,5,9q�6�   ��6K   �� *start_hours[0]+$ hh\:mm��{�6�   �� $ 	checkBox1��$ 	IsChecked��� 5�   
   -&   5        $ start2��5�      $��1q�6"   $��2��6.   $��2��6>   $��Center=�6�   $��16(�6�   $��5,7,5,11q�6�   ��6K   �� *start_hours[1]+$ hh\:mm��{�6�   �� $ 	checkBox2��$ 	IsChecked��� 5�   
   -'   5        $ start3��5�      $��1q�6"   $��2��6.   $��3��6>   $��Center=�6�   $��16(�6�   $��5,9,5,10.557q�6�   ��6K   �� *start_hours[2]+$ hh\:mm��{�6�   �� $ 	checkBox3��$ 	IsChecked��� 5�   
   -(   5        $ start4��5�      $��1q�6"   $��2��6.   $��4��6>   $��Center=�6�   $��16(�6�   $��5,8.443,5,9.114q�6�   ��6K   �� *start_hours[3]+$ hh\:mm��{�6�   �� $ 	checkBox4��$ 	IsChecked��� 5�   
   -)   5        $ start5��5�      $��1q�6"   $��2��6.   $��5��6>   $��Center=�6�   $��16(�6�   $��5,8.886,5,8.671q�6�   ��6K   �� *start_hours[4]+$ hh\:mm��{�6�   �� $ 	checkBox5��$ 	IsChecked��� 5�   
   -*   5        $ start6��5�      $��1q�6"   $��2��6.   $��6��6>   $��Center=�6�   $��16(�6�   $��5,9.329,5,8.671q�6�   ��6K   �� *start_hours[5]+$ hh\:mm��{�6�   �� $ 	checkBox6��$ 	IsChecked��� 5�   
   -+   5        $
 err1��5�      $-��'ניתן להזין ספרות בלבד��6   $��4��6>   $��Right=�6N   $y�	Collapsed=�6j   $��0,85,0,0q�6�   $	��Top=�6�   
���  ��$��2��6�   �� 5�   
   -,   5        $
 err2��5�      $-��'ניתן להזין ספרות בלבד��6   $��4��6>   $��Right=�6N   $y�	Collapsed=�6j   $	��Top=�6�   
���  ��$��31��6�   $��3��6�   �� 5�   
   --   5        $ button2��5�      $��
עדכון��6"   $��3��62   $��0,15,105,15q�6B   $��8��6W   $��22(�6d   $��2��6�   5�      5�      