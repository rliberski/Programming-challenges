   M S B A M L   `   `   `  ����>  :000, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_000_000  5   	       _000.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:_000     5   	     � Title$  Unit converter��5   	   $	��163��6    $	��300��6-    � 
ResizeMode$ NoResize=�69   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��75* �6   �� 5      $	��75* �6   .+�5   
   �� -   5         ��Name$ FromComboBox��5      $
��Left=�6)   $��	10,32,0,0q�6D   $	��Top=�6W   $	��127��6o   $��1��6{   $��22��6�   ��5      �� 5      .R�5      �� ��6    �� *name+5      5      �� 5   
   -   5        $ 
ToComboBox��5      $
��Left=�6'   $��	10,60,0,0q�6B   $	��Top=�6U   $	��127��6m   $��1��6y   $��22��6�   ��5      �� 5      .R�5      �� ��6    �� *name+5      5      �� 5   
   -   5        $ DataTypeComboBox��5      $��1��6-   $
��Left=�6=   $��10,5,0,0q�6X   $	��Top=�6j   $	��127��6�   $��22��6�   ��5      �� 5      .R�5       �� ��6    �� *type+5!      5#      �� 5$   
   -   5         ��Name$ ConvertButton��5$      $��Convert��6(   $
��Left=�6:   $��	10,88,0,0q�6U   $	��Top=�6h   $	��127��6�   $��23��6�   $��1��6�   6�   �� 5%   
   -   5         ��Name$ ValueBox��5%      $
��Left=�6$   $��23��6?   $��	10,32,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   6�   �� 5&   
   -   5        $ 	ResultBox��5&      $
��Left=�6%   $��23��6@   $��	10,60,0,0q�6L   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   {�.  6�   5'      5(      