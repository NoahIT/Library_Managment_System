   M S B A M L   `   `   `  ����W  SLMS_VIKO_Nojus_Rascius_PI22A, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:LMS_VIKO_Nojus_Rascius_PI22ALMS_VIKO_Nojus_Rascius_PI22A  5   	   -    'LMS_VIKO_Nojus_Rascius_PI22A.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:LMS_VIKO_Nojus_Rascius_PI22A     5   	     � Title$#  Book Library Managment System��5   	   $	��450��5	   	   $	��300��5
   	    � 
ResizeMode$ NoResize=�5   	   ��5      �� 5   
    �� ImageSource$' !Images/BackgroundImageLibrary.jpg��6    �� Opacity$	 0.2Q�6E   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��300 �6   �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $	��100��6   $	��150��5       $��Images/BookLogo.png��5!      $��1��5"      $��100,11,100,81q�5#      $��3��5$      �� 5&   
   $��Username��6   $
��Left=�5'      $	��Top=�5(      
�������$��Roboto)�5*      $��1��5+      $��2��5,      $��	74,52,0,0q�6   �� 5-   
   $��Password��6   $
��Left=�5.      $	��Top=�5/      
�������$��Roboto)�51      $��1��52      $��3��53      $��	76,12,0,0q�6   �� 55   
   -   5         ��Name$ UsernameTbx��55      $��Center=�56      $	��Top=�57      $	��152��58      $��1��6   $��2��59      $��0,76,0,0q�6   $��23��5:      $��2��6   G� 5;   
   -   5         G�Name$ PasswordPsb��5;      $��Center=�5<      $��Center=�5=      $��23��5>      $	��152��6"   $��1��5?      $��3��6&   �� 5A   
   -   5         ��Name$ LogInBtn��5A      $��Log In��5B      $��Center=�5C      $	��Top=�5D      $��80��6)   
�������
�������
������ $��26��5F   *   $��1��5G      $��0,96,0,0q�6!   $��3��5H      $��2��6   	 � 	Resources	 5K      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5L      "
 ��6   .�5M      ��  �@��CornerRadius$ 5��65   5N      5O      5P      �� 5R   
   $��I Don't Have An��6   $
��Left=�5S      $	��Top=�5T      
�������$��Roboto)�5V      $��1��5W      $��4��5X      $��	83,48,0,0q�6   �� 5Y   
   -   5         ��Name$ LogInAccountTbx��5Y      $��Account��5Z      $
��Left=�5[      $��Medium"�5\      
�����_�$	��Top=�5^      $��Roboto)�5_      $��1��5`      $��12(�5a      $��4��5b      $��
175,53,0,0q�6!    � Cursor$
 Hand��5d      $��	Underline{�5e      �� 5g   
   $��Log In To Your Account��6   $��Center=�5h      $��0,10,0,0q�5i      $��2��6"   $	��Top=�5j      $��1��6(   
�������$��20(�5k   #   $��Roboto)�5l      5m      5n      