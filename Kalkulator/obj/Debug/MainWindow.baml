   M S B A M L   `   `   `  ����E  AKalkulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Kalkulator
Kalkulator  5   	   G(clr-namespace:Kalkulator.Other.ViewModelKalkulator.Other.ViewModel  5   	       Kalkulator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Kalkulator     5   	   >	viewModel(clr-namespace:Kalkulator.Other.ViewModel     5   	   $	��600��5	   	   $	��920��6     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      .  (Kalkulator.Other.ViewModel.MainViewModel  5   
   .��5      �� ���#FFA500 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5"      A� -   5        
���  ��$��0��5"   !   $��10��6.   $��10��6:   $
��Left=�6E   $	��Top=�6`   $��	10,10,0,0q�6x    � ToolTip$ 	Close app��6�   6�   A� 5#      -   5        
��� ���$��0��5#   $   $��10��61   $��10��6=   $
��Left=�6H   $	��Top=�6c   $��	25,10,0,0q�6{   $ Minimize app��6�   6�   �� 5%      $��Salary Calculator��6   $��Center=�5&      $��Center=�5'      
�������$��18(�5)      $��0,0,0,0q�5*      �� 5-      $��1��6   .+�56      	� $
��Home��6   $��50��57      
�������$��14(�59         
MenuButton#��[  5:       d� 	IsChecked$
 TrueY�5;      ��5<      �� *HomeViewCommand+	� 5?      $��Calculator UOP��6   $��50��5@      
�������$��14(�5B      #��[  5C      ��5E      �� *UOP_CalculatorViewCommand+	� 5G      -   5        $��Calculator B2B��5G      $��50��5H      
�������$��14(�5J      #��[  5K      ��5L      �� *B2B_CalculatorViewCommand+6L   	� 5O      -   5        $��IT Comparer��5O      $��50��5P      
�������$��14(�5R      #��[  5S      ��5T      �� *IT_comparerViewCommand+6I   5V      �� 5Y      $��1��6   $��1��5Z      $��10q�5[      ��5\      �� *CurrentView+5^      5_      5`      