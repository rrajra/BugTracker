   M S B A M L   `   `   `  ����E  ABugTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BugTracker
BugTracker  5   	       BugTracker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BugTracker     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $	��399��60   $��0,10,0,0q�6=   $	��Top=�6O   $	��782��6g   .@�5      �� $��Add bug��6   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $	��26* �6+   �� 5      $	��77* �6+   �� 5      $
��673* �6+   .+�5      �� -   5         ��Name$ addBug��5      $��Add bug��6-   $
��Left=�6?   $	��Top=�6Z   $��75��6r   $��2��6�   $��588.336,341,0,0q�6�   �� 5      $
��Bugs��6   $
��Left=�6+   $	��Top=�6F   $��2��6^   $��	10,10,0,0q�6r   �� 5      -   5         ��Name$ 	nameOfBug��5      $
��Left=�61   $��23��6L    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��120��6�   $��	10,46,0,0q�6�   $��3��6�   $
��Name��6�   �� 5      -   5         ��Name$ bugList��5   "   $
��Left=�63   $	��100��6N   $	��Top=�6[   $	��100��6s   $��3��6   $��
10,261,0,0q�6�   . �5      /� .T�5      J� .*�6(   .*�5   "   �� $�RichTextBox��6&   5      5      5      �� 5      -   5        $ descriptionBox��5      $��2��66   $
��Left=�6F   $��23��6a   $��65.336,46,0,0q�6m   $
 Wrap=�6�   $��Description��6�   $	��Top=�6�   $	��120��6�   �� 5      -   5        $��	Add image��5      $��2��61   $
��Left=�6A   $��229.336,49,0,0q�6\   $	��Top=�6t   $��75��6�   6�   5      5      �� 5       -   5         ��Name$ viewBugs��5       $��	View Bugs��6(   .��5!      � -   5         �Name$ viewBugGrid��5!      ���	#FFE5E5E5 5"      �� 5#      $	��19* �6+   �� 5$      $
��757* �6+   5&      5'      5(      5)      5*      