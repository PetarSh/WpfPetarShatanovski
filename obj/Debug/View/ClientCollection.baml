   M S B A M L   `   `   `  ����N  JWpfPetarShatanovski, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WpfPetarShatanovski.ViewModelWpfPetarShatanovski.ViewModel  5      /    )WpfPetarShatanovski.View.ClientCollection   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      A	viewmodel+clr-namespace:WpfPetarShatanovski.ViewModel     5        � 	Resources  5
      ��%    5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��99* �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   � $��2��6   $��	0,0,0,117q�6#   $��2��66   .+�5      �� $��CLIENT MANAGEMENT APP��6   $��16(�63   $��360,3,230,3q�6A   $
��Auto��6V   6e   5      &   System.Windows.Controls.DataGrid  5   
   $��1��6   $��0,21,0,10.333q�5   G   $��2��6^   ��5       �� *ClientCollection+ �� Mode$ OneWay=� �� SelectedItem 5      �� *SelectedClient+$ TwoWay=�5      � 5!   
   $��2��6   $��0,0.333,0,290q�6   $��2��64    5"      �� 5#      $
��Auto �6    60   �� 5$      $
��Auto �6    60    5&      �� 5'      $
��Auto �6#   62   �� 5(      $
��Auto �6#   62   �� 5)      $
��Auto �6#   62   �� 5*      $
��Auto �6#   62   .+�5,      �� $��0��6   $��0��6%   $��
First Name��65   $��3,4,65.333,1.667q�6G   6c   �� 5-      $��0��6   $��1��6%   $��	Last Name��65   6H   �� 5.      $��0��6   $��1��6%   $��
Birth Date��65   $��197.667,1,-10.667,4.667q�6G   $��3��6h   6~   �� 50      -   5         ��Name$ FirstNameNew��50      $��1��6-   $��0��6;   $��3,0.333,21.333,23.667q�6�   ��6L   �� *	FirstName+$ TwoWay=� �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 51      -   5        $ LastNameNew��51      $��1��6+   $��1��68   $��0,2.333,10.333,21.667q�6�   $
��Auto��6�   $��2��6�   ��6H   �� *
LastName+$ TwoWay=� . $ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  52      -   5        $��BirthDateNew��52      $��1��6-   $��1��6:   $"��197.667,2.333,-59.667,21.667q�6�   $��3��6�      SelectedDate$ 
2001-01-01X�6�   	   Text	 6J   �� *	BirthDate+$ TwoWay=� . $ PropertyChanged=�6�   �� 54      $��Choose addresses��6   $��2��60   $��3,49.333,124,-22.333q�6D   $��1��6b   6q   �� 56      -   5        
 ��Name$
 listboxAddress��56      $��Center=�6.   $
��Auto��6K   $��1,72.333,-59.333,-89.333q�6Y   $	��Top=�6{   $	��461��6�    �� SelectionMode$ Multiple=�57   �   $��1��6�    6   �� *SelectedAddress+$ TwoWay=���6J   �� *AddressesCollection+$ TwoWay=���58      �� 59      .R�5:      � .+�5;      �� $��1��6(   ��68   �� *Street+�� 5<      $��2��6(   ��68   �� *City+�� 5=      $��3��6(   ��68   �� *	Country+�� 5>      $��4��6(   ��68   �� *AddressType+5@      5A      5C      5E      � 5H   
   $��2��67   $��	0,0,0,117q�6K   $��2��6^    � DataContext 6   �� *SelectedAddress+6^   �� 5J   
   $��2��6   $��0,250,242,249.667q�6"    �� Orientation$ 
Horizontal=�6>   $��Right=�6W   .+�5K      �� $��Add From XML��6-   $��0,0,0,0.333q�6D   ��6   �� *Xml+6D   �� 5L      $��
WorldClock��67   ��6   �� *GetWorldClock+67   �� 5M      $��Add New��6-   ��6   �� *Add+6-   �� 5N      $��Update��6.   ��6   �� *Save+6.   �� 5O      $��Delete��60   ��6   �� *Delete+60   5P      �� 5Q   
   $��2��6   $��	0,0,0,117q�6&   $��2��69   6L   5R      5S      