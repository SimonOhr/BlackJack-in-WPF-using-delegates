   M S B A M L   `   `   `  ����P  LTheDelegatesBlackJack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:TheDelegatesBlackJackTheDelegatesBlackJack  5      ,    &TheDelegatesBlackJack.PlayerController   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:TheDelegatesBlackJack     5      .��5	      � -   5          �Name$  PlayerControllerGrid��5	      ���	#FFAAA8C9 � ColumnDefinitions 5
   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ PlayerNameOutput��5      $��0��6.   $��0��6=   $��
10,22,0,22q�6O   $��Center=�5   
   $��Center=�6)   $	��200��6F   
�����p�$
��Bold"�6k    �� TextAlignment$ Center=�6}    � ToolTip$ Shows the current player��6�   �� 5   
   -   5        $ PlayerCardOutput��5      $��1��6.   $��0��6;   $��20,20,20,20q�6K   $��Center=�6`   $��Center=�6}   $	��180��6�   $	��160��6�   
�����p�$
��Bold"�5   )   �� 5    
   -   5         ��Name$ PlayerScoreOutput��5       $��2��6-   $��20,20,20,20q�6:   $��Center=�6O   $��Center=�6l   $	��120��6�   
�����p�$
��Bold"�6�    �� TextAlignment$ Center=�6�   5!      5"      