   M S B A M L   `   `   `  ����F  BKingWilliam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KingWilliamKingWilliam  5   	       KingWilliam.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KingWilliam     5   	     � Title$
  Main��5   	    � 
ResizeMode$ CanMinimize=�6    � WindowStartupLocation$ CenterScreen=�6/    � WindowState$ Normal=�6T   $	��791��6i   $��1440.8��6v   .��5	      � $	��811��6   $	��Top=�6   $��10,0,0,0q�60   .+�5   
   �� -   5         ��Name$ button��5      $
��Left=�6!   $��126,293,0,0q�6<   $	��Top=�6Q   $	��296��6i   $��71��6u   ���#4682B4.��5      �� $	��263��6    �� Orientation$ 
Horizontal=�6%   $��63��6>   .+�5      �� $)��#Новое бронирование��6   $��Center=�65   
�������$��26(�6d   $��0,16,0,15.2q�6r   $��Arial)�6�   $��42��6�   5      5      �� 5   
   $��0 0 0 1q�6   ���	#FF3556C8$	��119��6C   $	��Top=�6P   $��	0,0,-93,0q�6h   ._�5      �� -   5         ��Name$ image��5      $��/logo_site.png��6#    J� RenderTransformOrigin$ -0.491,-0.017&�6;   $��129,-68,1132,-47q�6a   5      �� 5   
   -   5        $ button_Copy1��5      $
��Left=�6'   $��564,293,0,0q�6B   $	��Top=�6W   $	��296��6o   $��71��6{   ���#4682B4.��5      �� $	��183��6   $ 
Horizontal=�6%   $��64��6>   .+�5      �� $��Услуги��6   $��Center=�6)   
�������$��26(�6X   $
��0,16q�6f   $	��141��6t   $��Arial)�6�   $��42��6�   5      5      �� 5   
   -   5        $ button_Copy5��5      $
��Left=�6'   $��982,293,0,0q�6B   $	��Top=�6W   $	��368��6o   $��71��6{   ���#4682B4.��5      �� $	��277��6   $ 
Horizontal=�6%   $��64��6>   .+�5      �� $��
Гости��6   $��Center=�6(   
�������$��26(�6W   $
��0,16q�6e   $	��303��6s   $��Arial)�6   $��48��6�   5      5       �� 5!   
   -   5         ��Name$ lblReservation��5!      $��Бронирование��6(   $
��Left=�6?   $��126,204,0,0q�6Z   $	��Top=�6o   $��46(�6�   $��0,0,0,2q�6�   $��Arial Unicode MS)�6�   ��6�   Z� 6�   �� 5"   
   -   5        $ lblServices��5"      $��Доп. услуги��6%   $
��Left=�6;   $��564,204,0,0q�6V   $	��Top=�6k   $��46(�6�   $��0,0,0,2q�6�   $��Arial Unicode MS)�6�   ��6�   Z� 6�   �� 5#   
   -   5        $ 
btnPricing��5#      $
��Left=�6%   $��126,521,0,0q�6@   $	��Top=�6U   $	��296��6m   $��71��6y   ���#4682B4.��5$      �� $	��227��6   $ 
Horizontal=�6%   $��63��6>   .+�5%      �� $��Прайс-листы��6   $��Center=�6.   
�������$��26(�6]   $��0,16,0,15.2q�6k   $	��219��6�   $ 0.688,0.584&�6�   $��Arial)�6�   $��42��6�   5&      5(      �� 5)   
   -   5        $ btnEditTransaction��5)      $
��Left=�6-   $��564,400,0,0q�6H   $	��Top=�6]   $	��296��6u   $��72��6�   ���#4682B4.��5*      �� $	��207��6   $ 
Horizontal=�6%   $��64��6>   .+�5+      �� $��Транзакции��6   $��Center=�6-   
�������$��26(�6\   $��0,16,0,15.2q�6j   $��Arial)�6   $	��234��6�   $��43��6�   5,      5.      �� 5/   
   -	   5        $ lblServices_Copy��5/      $��Базы данных��6*   $
��Left=�6@   $��982,204,0,0q�6[   $	��Top=�6p   $��46(�6�   $��0,0,0,2q�6�   $��Arial Unicode MS)�6�   ��6�   Z� 6�   �� 50   
   -
   5        $ button_Copy��50      $
��Left=�6&   $��982,404,0,0q�6A   $	��Top=�6V   $	��368��6n   $��72��6z   ���#4682B4.��51      �� $	��293��6   $ 
Horizontal=�6%   $��75��6>   .+�52      �� $��Бронирования��6   $��Center=�6/   
�������$��26(�6^   $
��0,16q�6l   $	��357��6z   $ 0.5,0.5&�6�   $��Arial)�6�   z�53      V� 54      .~�55      �� �� 56      �� 57      	 �� Angle$	 -0.124Q�6.   T� 58      59      5;      5<      5>      �� 5?   
   -   5        $ lblServices_Copy1��5?      $��Прайс-листы��6+   $
��Left=�6A   $��126,424,0,0q�6\   $	��Top=�6q   $��46(�6�   $��0,0,0,2q�6�   $��Arial Unicode MS)�6�   ��6�   Z� 6�   �� 5@   
   -   5        $ btnPricing_Copy1��5@      $
��Left=�6+   $��982,521,0,0q�6F   $	��Top=�6[   $	��296��6s   $��71��6   ���#4682B4.��5A      �� $	��227��6   $ 
Horizontal=�6%   $��63��6>   .+�5B      �� $!��Список номеров��6   $��Center=�61   
�������$��26(�6`   $��0,16,0,15.2q�6n   $	��217��6�   $ 0.688,0.584&�6�   $��Arial)�6�   $��42��6�   5C      5E      5I      5J      