   M S B A M L   `   `   `  ����E  AWPF Galery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_Galery
WPF_Galery  5   	       WPF_Galery.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_Galery     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6    �� 5      $��3* �6   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $��8* �6    �� 5      $��* �6    .+�5      �� -   5         ��Name$ imageFolderListBox��5   #   $��0��6   ���#0A0606��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $
��Wrap=�6(   $��12(�5   (   
���������5   (   �� *Title+5       5!      5#      � 5%      $��1��6   ���#0A0606 5'      �� 5(      $��* �6'   �� 5)      $��* �6'   .+�5,      �� -   5        $
��Left=�5,      $��80��5-      $��8q�5.      $��0��5/      ���#FF9214.��52   .   Add63   �� 53      -   5        $��Right=�53      $��80��54      $��8q�55      $��1��56      ���#FF9214.��58   0   Remove68   59      5:      �� 5<   
   -   5        $ imageListBox��5=      $��1��5<      ���#0A0606��5@      �� 5A      .R�5B      �� $ 
Horizontal=�6!   .+�5C      �� $��50��6    $��50��6,   ��67   �� *Photo+�� 5D      $ Vertical=�6%   .+�5E      �� $
��Wrap=�6(   $��12(�5F   )   
���������5H   (   �� *Title+�� 5I      $
��Wrap=�6(   $��12(�5J   )   
���������5L   (   �� *Size+�� 5M      $
��Wrap=�6)   $��12(�5N   *   
���������5P   )   �� *Date+5Q      5S      5T      5V      5W      5X      