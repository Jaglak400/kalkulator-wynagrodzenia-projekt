   M S B A M L   `   `   `  ����E  AKalkulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Kalkulator.Other.ViewKalkulator.Other.View  5      .    (Kalkulator.Other.View.UOP_CalculatorView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Kalkulator.Other.View     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $ ��Wynagrodzenie miesięczne:��6   $��0��64   $��0��6A   $��5q�6Q   
�������6\   �� 5   
   -   5         ��Name$ salaryTextBox��5      $��0��6)   $��1��66   $��5q�6F   
���   �6d   �� 5   
   -   5         ��Name$ calculateButton��5      $��Oblicz��6*   $��4��6;   $��2��6H   $��5q�6\   6g   �� 5   
   $��5��6   $��0��6"   $��2��62   $��10q�6F   .+�5      �� $*��$Składka na ubezpieczenie emerytalne��6   
�������6C   �� 5       -   5         ��Name$" retirementInsuranceTextBlock��5       
�������6>   �� 5"      $*��$Składka na ubezpieczenie zdrowotne:��6   
�������6C   �� 5#      -   5        $ healthInsuranceTextBlock��5#      
�������6:   �� 5%      $��Podstawa opodatkowania:��6   
�������67   �� 5&      -   5        $ taxableIncomeTextBlock��5&      
�������68   �� 5(      $��Podatek dochodowy:��6   
�������62   �� 5)      -   5        $ taxTextBlock��5)      
�������6.   �� 5+      $��Wynagrodzenie netto:��6   
�������64   �� 5,      -   5        $ netIncomeTextBlock��5,      
�������64   5-      5.      5/      