   M S B A M L   `   `   `  ����P  LTheDelegatesBlackJack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TheDelegatesBlackJackTheDelegatesBlackJack  5   	   &     TheDelegatesBlackJack.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TheDelegatesBlackJack     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   .��5	      � -   5         �Name$ 	GameBoard��5	      
������� � ColumnDefinitions 5
      �� 5   
   $��* �6   �� 5   
   $��* �6   �� 5   
   $
��0.5* �6    � RowDefinitions 5      �� 5   
   $��5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
NewGameBtn��5      $�� 2��6%   $��1��66   
������� �� TextAlignment$ Center=�6Z   $
��Bold"�6{   $	��5,5q�6�   .��6�   
New Game5      �� 5   
   -   5        $ ViewNextBtn��5      $�� 2��6'   $��2��68   
�������$ Center=�6\   $
��Bold"�6}   $	��5,5q�6�   .��6�   ViewNextPlayer5      �� 5   
   -   5        $ HitBtn��5      $�� 2��6"   $��3��63   
�������$ Center=�6W   $
��Bold"�6x   $	��5,5q�6�   .��6�   Hit5       �� 5!   
   -   5        $ HoldBtn��5!      $�� 2��6#   $��4��64   
�������$ Center=�6X   $
��Bold"�6y   $	��5,5q�6�   .��6�   Hold5#      �� 5$   
   -   5        $ 
ShuffleBtn��5$      $�� 2��6&   $��5��67   
�������$ Center=�6[   $
��Bold"�6|   $	��5,5q�6�   .��6�   	Shuffle5&      ,   &TheDelegatesBlackJack.PlayerController  5(   
   -   5          Name$ DealerController��5(   !   $��0��6;   $��5��6H   $��0��6Y   $��20,20,20,20q�6i     5)   
   -   5        $ PlayerController��5)   !   $��0��6;   $��5��6H   $��1��6Y   $��20,20,20,20q�6i   5*      5+      