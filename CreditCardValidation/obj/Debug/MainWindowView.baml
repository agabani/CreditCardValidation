   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=0.13.1.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	    CreditCardValidation)   #CreditCardValidation.MainWindowView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	     � Title$  Credit Card Validation��5   	   $	��250��6(   $	��525��65    � 
ResizeMode$ CanMinimize=�6A   (   "MahApps.Metro.Controls.MetroWindow   WindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5	      �� -   5         ��Name$ AboutButton��5	      $��About��6*   6V   5
         Flyouts 5      +   %MahApps.Metro.Controls.FlyoutsControl  5   
   5      .��5      � .+�5   
   � $	��Top=�6   $��0,10,0,0q�6'   .+�5      �� $��Credit Card Validation��6   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   �� 5      -   5        $
��Left=�5      $��23��61   $��	10,41,0,0q�6=    �� TextWrapping$
 Wrap=�6P   $	��Top=�6e   $	��419��6}    � ToolTip$ Credit Card Number��6�   ��5      �� *ValidationNumber+5      �� 5      -   5        $��Validate��5      $
��Left=�6(   $��
434,41,0,0q�6C   $	��Top=�6W   $��75��6o   6z   �� 5      $
��Left=�6   $��
279,72,0,0q�63   $
��Wrap=�6G   $	��Top=�6~   $	��150��6�   ��6[   �� *ValidationMessage+6�   5      � 5   
   $��	0,105,0,0q�6   $	��Top=�6"   .+�5      �� $(��"Credit Card Check Digit Calculator��6   $
��Left=�6A   $	��Top=�6\   $��	10,10,0,0q�6t   �� 5       -   5        $
��Left=�5       $��23��61   $��	10,41,0,0q�6=   $
 Wrap=�6P   $	��Top=�6�   $	��389��6�   ��6d   �� *CalculateNumber+6�   �� 5!      -   5        $��	Calculate��5!      $
��Left=�6)   $��
434,41,0,0q�6D   $	��Top=�6X   $��75��6p   6{   �� 5"      $
��Left=�6   $��
404,41,0,0q�63   $
��Wrap=�6G   $	��Top=�6}   $��25��6�   $��25��6�    �� TextAlignment$ Center=�6�   $��18(�6�   $
��Bold"�6�   ��6[   �� *CheckDigitNumber+6�   �� 5#      $
��Left=�6   $��
279,72,0,0q�63   $
��Wrap=�6G   $	��Top=�6}   $	��150��6�   ��6[   �� *CalculateMessage+6�   5$      #   MahApps.Metro.Controls.Flyout  5&   
   -   5          Name$ AboutFlyout��5&      	   Position$		 Top=�6/   $	��100��6>   
   Theme$

 Dark=�6j      IsOpen 6K   �� *AboutFlyout+.��5'      � .+�5(      �� $1��+Credit Card Validation (SAMPLE APPLICATION)��6   $��Center=�6N   $	��Top=�6k   $��18(�6�   �� 5)      $��Writen by Ahmed Agabani.��6   $
��Left=�6;   $	��Top=�6V   $��
281,23,0,0q�6n   $��10(�6�   �� 5*      $��Bottom=�6   $y��sA GUI programme that validates & generates check digits for credit card number using Luhn's "Modulus 10" algorithm.��67   $
��Wrap=�6�   $��	0,0,10,10q�6�   5+      5,      5.      5/      