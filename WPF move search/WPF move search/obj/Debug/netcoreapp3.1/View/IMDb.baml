   M S B A M L   `   `   `  ����J  FWPF move search, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_move_search.ViewWPF_move_search.View  5   	       WPF_move_search.View.IMDb   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WPF_move_search.View     5   	     � Title$
  IMDb��5   	   $	��450��6   $	��800��6#   
���   � � 	Resources 5
         searchListItemStyle �� 
TargetType �� Property �� Value  selectListItemStyle  searchListTemplate  selectedListTemplate��%-  &	        &	 �     &	 (    7   7   7   &	 �    7  7  7  7  7  7  7  7  7  7  �� 5   
   " ��6,   .�5      ��  � ��
 � ���6+   �� 5       � ��$ 16(�6)   �� 5       � ��$
 auto��6&   5      �� 5   
   " ��6,   .�5   
   ��  � ��
 �����6'   �� 5   
    � ��$ 12(�6%   �� 5   
    � ��$
 auto��6"   5      �� 5   
   .R�5      �� .+�5      �� 8��  ��6I   �� *Title+�� 5      8�� ��6I   �� *Year+�� 5      8�� ��6I   �� *Type+5      5      �� 5!   
   .R�5"      �� .+�5#      �� 8��  ��6I   �� *Title+�� 5$      8�� ��6I   �� *Year+�� 5%      8�� ��6I   �� *	Runtime+�� 5&      8�� ��6I   �� *	Country+�� 5'      8�� ��6I   �� *
Director+�� 5(      8�� ��6I   �� *
Language+�� 5)      8�� ��6I   �� *
Released+�� 5*      8�� ��6I   �� *Type+�� 5+      8�� ��6I   �� *
imdbRating+�� 5,      8��	 ��6I   �� *	imdbVotes+5.      5/      51      .��54      �  � ColumnDefinitions 55   
   �� 56      $��6* �6   �� 57      $��3* �6    � RowDefinitions 5:   
   �� 5;      $��* �6   �� 5<      $��4* �6   .+�5@      �� $
��auto��6   $��25q�5A      ��5B      �� *
MovieTitle+.��5C      5D      �� 5F      $
��auto��6   $��25q�5G      $��1��5H      
��� ���$��15(�5J      $��Black"�5K      ��5L      �� *SearchCommand+.��67   Search5N      �� 5Q   
   -   5         ��Name$ 	movieList��5Q      $��1��5R      
���   �#��[ 5U       �� SelectedItem 5T      �� *SelectedMovie+��5V      �� *AllMovie[0]+5Z      � 5\   
   $��1��6   $��1��6    5^      �� 5_      �� 5`       5c      �� 5d      �� 5e      .+�5h      �� ��5i      � 5j      .&�5k      �� 	 �� Path$	 
MovieImage�6"   
 �� IsAsync$

 True��64   5l      5n      �� 5p      $��1��6   $��2��5q      
���   �#��[ 5t      ��5s      �� *SearchSelectedMovie+5w      5y      5z      5{      