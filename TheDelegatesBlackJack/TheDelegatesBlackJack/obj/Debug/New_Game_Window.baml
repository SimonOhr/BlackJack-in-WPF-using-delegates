   M S B A M L   `   `   `  ����P  LTheDelegatesBlackJack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TheDelegatesBlackJackTheDelegatesBlackJack  5   	   +    %TheDelegatesBlackJack.New_Game_Window   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:TheDelegatesBlackJack     5   	     � Title$  New_Game_Window��5   	   $	��600��6!   $	��400��6.   .��5	      � 
�����p� � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��4* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��4* �6   .+�5   
   �� $��1��6   $��0��6!   $��Number Of Decks��61   $��Center=�6H   $
��Bold"�6e   4  .System.Windows.Automation.AutomationProperties   IsColumnHeader .    IsRowHeader . 6�   �� 5   
   -   5         ��Name$ 	DeckInput��5      $��2��6%   $��0��62   $��Input Number Here��6B   $��Center=�6[   $
��Bold"�6x   $��20,20,20,20q�6�   $	��350��6�   
�������6�   �� 5   
   $��3��6   $��0��6!   $��Number Of Players��61   $��Center=�6J   $
��Bold"�6g    .  . 6�   �� 5   
   -   5        $ PlayerInput��5      $��4��6'   $��0��64   $��Input Number Here��6D   $��Center=�6]   $
��Bold"�6z   $��20,20,20,20q�6�   $	��350��6�   
�������6�   �� 5   
   -   5        $��5��5      $��130,60q�6   $
��Bold"�6.   
�������.��6l   Start New Game5      5      5       