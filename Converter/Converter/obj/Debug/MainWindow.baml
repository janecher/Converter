   M S B A M L   `   `   `  ����D  @Converter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Converter	Converter  5   	       Converter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Converter     5   	     � Title$  
MainWindow��5   	   $��387.304��6   $��467.932��6-   .��5	      � $
��Left=�6   $��0,0,-5.714,-4.143q�6&   $	��468��6A   ���	#FFF1FBFD.+�5
   
   �� $��Choose conversion:��6   $��
129,51,0,0q�6-   $	��Top=�6A   $��27��6Y   $	��147��6e   $
��Bold"�6q   $��14(�6�   $
��Left=�6�   �� 5   
   -   5         ��Name$ txtInput��5      $
��Left=�6$   $��23��6?   $��129,137,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��201��6�    J� RenderTransformOrigin$ 	0.5,1.898&�6�   �� 5   
   -   5         ��Name$ 	lblResult��5      $�� ��6#   $
��Left=�6.   $��129,216,0,0q�6I   $	��Top=�6^   $ 0.502,1.054&�6v   $	��201��6�   ���	#FFF1FBFD$
��Bold"�6�   
���   �$��14(�6�   $��36��6�   �� 5   
   -   5         ��Name$ comboBoxChooseConvertion��5      $
��Left=�65   $��
129,94,0,0q�6P   $	��Top=�6d   $	��201��6|   ��6�   Z� .@�5      �� -   5         ��Name$! txtBlockFromCmToFeetAndInch��5      $
��Wrap=�6=   $ ��From cm to inches and feet��6Q   �� 5      -   5        $ txtBlockFromCmToInch��5      $
��Wrap=�66   $��From cm to inches��6J   �� 5      -   5        $! txtBlockFromFeetAndInchToCm��5      $
��Wrap=�6=   $ ��From feet and inches to cm��6Q   �� 5      -   5        $ txtBlockFromInchToCm��5      $
��Wrap=�66   $��From inches to cm��6J   �� 5      -   5        $ txtBlockFromCelToFahr��5      $
��Wrap=�67   $ ��From Celsius to Fahrenheit��6K   �� 5      -	   5        $ txtBlockFromFahrToCel��5      $
��Wrap=�67   $ ��From Fahrenheit to Celsius��6K   �� 5      -
   5        $ txtBlockFromKgToLb��5      $
��Wrap=�64   $��From kgs to lbs��6H   �� 5      -   5        $ txtBlockFromLbToKg��5      $
��Wrap=�64   $��From lbs to kgs��6H   5      �� 5   
   -   5         ��Name$ 
btnConvert��5      $��Make a conversion:��6%   $
��Left=�6B   $��129,180,0,0q�6]   $	��Top=�6r   $	��201��6�   6�   �� 5   
   -   5        $ btnClean��5      $��Clean��6#   $
��Left=�63   $��129,268,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $ btnExit��5      $
��Exit��6"   $
��Left=�61   $��255,268,0,0q�6L   $	��Top=�6a   $��75��6y   $ 1.063,0.473&�6�   6�   5      5      