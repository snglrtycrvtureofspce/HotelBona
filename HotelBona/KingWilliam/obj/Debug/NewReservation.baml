   M S B A M L   `   `   `  ����F  BKingWilliam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KingWilliamKingWilliam  5   	        KingWilliam.NewReservation   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KingWilliam     5   	     � Title$  NewReservation��5   	   $��804.654��6    $��1345.593��61    � 
ResizeMode$ CanMinimize=�6B    � WindowState$ Normal=�6[   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��359* �6   �� 5      $
��430* �6    � ColumnDefinitions 5   
   �� 5      $
��129* �6   �� 5      $
��667* �6   �� 5      $
��549* �6   .+�5   
   �� $��0 0 0 1q�6   ���	#FF3556C8$
��Left=�6D   $	��119��6_   $	��Top=�6l   $
��1534��6�   $��3��6�   ._�5      �� -   5         ��Name$ image��5      $��/logo_site.png��6#    J� RenderTransformOrigin$ -0.491,-0.017&�6;   $��209,-68,1052,-47q�6a   5      �� 5   
   -   5         ��Name$ lblNewReservationTitle��5      $)��#Новое бронирование��60   $
��Left=�6M   $��
70,127,0,0q�6h   $	��Top=�6|   $��38(�6�   $
��Bold"�6�   $��1��6�   $��Arial)�6�   �� 5   
   -   5        $��cnvGuest��5   )   $��108,295,327,35q�6   $y�Hidden=�69   $��1��6M   $��2��6]   .+�5      �� -   5        $ lblGuestFirstName��5      $��Имя:��6/   $��Center=�6?   $
��Left=�6c   $	��Top=�6~   $��16(�6�    �� Left$ 13��6�   
	 �� Top$	 6��6�   �� 5      -   5        $ lblPhone��5      $"��Номер телефона:��6&   $��Center=�6@   $
��Left=�6d   $��Center=�6   $��16(�6�   $	��133��6�   $	 84��6�   �� 5      -   5        $ lblEmail��5      $��E-mail:��6&   $��Center=�69   $
��Left=�6]   $��Center=�6x   $��16(�6�   $	��101��6�   $	 480��6�   $	 84��6�   �� 5      -   5        $ 
lblAddress��5      $"��Номер паспорта:��6(   $��Center=�6C   $
��Left=�6g   $��Center=�6�   $��16(�6�   $	��133��6�   $	 45��6�   �� 5      -   5        
 ��Name$
 txtFirstName��5      $
��Left=�6,   $��23��6G    �� TextWrapping$
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��283��6�   $	 152��6�   $	 6��6�   �� 5      -	   5         ��Name$	 pol��5      $��1��6$   $��1��64   $��2��6A   $ -0.171,-0.954&�6U   $	 606��6{   $	 51��6�   $
��Left=�6�   $��Center=�6�   $��96��6�   .@�5      �� $��Мужской��6   6.   �� 5      $��Женский��6   6.   5       �� 5!      -
   5        $
 txtPhone��5!      $
��Left=�6(   $��23��6C   $
 Wrap=�6O   $�� ��6c   $	��Top=�6k   $	��283��6�   $	 152��6�   $	 90��6�   �� 5"      -   5        $
 
txtAddress��5"      $
��Left=�6*   $��23��6E   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��283��6�   $	 152��6�   $	 48��6�   �� 5#      -   5        $
 txtEmail��5#      $��Center=�6(   $��23��6E   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��283��6�   $	 606��6�   $	 92��6�   �� 5$      -   5        $ lblGuestLastName��5$      $��Фамилия:��6.   $��Center=�6B   $
��Left=�6f   $��Center=�6�   $��16(�6�   $	 502��6�   �� 5%      -   5        $
 txtLastName��5%      $
��Left=�6+   $��23��6F   $
 Wrap=�6R   $�� ��6f   $��Center=�6n   $	��283��6�   $	 606��6�   $	 6��6�   �� 5&      -   5        $ lblPostalCode��5&      $��Пол:��6+   $��Center=�6;   $
��Left=�6_   $��Center=�6z   $��16(�6�   $	��101��6�   $	 482��6�   $	 45��6�   5(      �� 5)   
   -   5        $��cnvReservation��5)   ?   $��116,300,133,227q�6   $y�Visible=�6*   $��2��6U   $��2��6i   .+�5*      �� -   5        $
 txtPrice��5*      $��32��6(   $	 398��64   $
 Wrap=�6F   $�� ��6Z   $		 208��6b   $	��147��6s   $��16(�6   $
��Left=�6�   $��Center=�6�   �� 5+      -   5         ��Name$ 	btnSubmit��5+      $ ��Забронировать��6(   $��Center=�6@   $	��Top=�6]   $	��210��6u   $��46��6�   ���#4682B4$��18(�6�   ���	#FFF1F1F1$ 84��6�   $		 248��6�   6�   �� 5,      -   5        $ 	btnCancel��5,      $��Отменить��6(   $��Center=�6;   $	��Top=�6X   $	��211��6p   $��46��6|   ���#4682B4$��18(�6�   ���	#FFF1F1F1$	 334��6�   $		 248��6�   �� 5-      -   5        $ lblStartDate��5-      $��Дата заезда:��6*   $��Center=�6A   $
��Left=�6e   $��Center=�6�   $��16(�6�   $	��178��6�   $ 45��6�   �� 5.      -   5        $ 
lblEndDate��5.      $��Дата отьезда:��6(   $��Center=�6@   $
��Left=�6d   $��Center=�6   $��16(�6�   $	��192��6�   $ 40��6�   $	 46��6�   (  "System.Windows.Controls.DatePicker  5/      -   5        $��dpiStartDate��5/      $
��Left=�6-   $	��Top=�6H   $��16(�6`   $	��132��6o   $	 233��6{   $	 3��6�   |�.  6�     50      -   5        $��
dpiEndDate��50      $
��Left=�6+   $	��Top=�6F   $	��132��6^   $��16(�6j   $��32��6y   $	 239��6�   $	 62��6�   |�.  6�   �� 51      -   5        $ lblRoomType��51      $��Тип номера:��6)   $��Center=�6?   $
��Left=�6c   $��Center=�6~   $��16(�6�   $	��111��6�   $ 78��6�   $		 114��6�   �� 52      -   5        $ cmbRoomType��52      $
��Left=�6,   $��Center=�6G   $	��120��6b   $	 244��6n   $		 118��6�   $��16(�6�   �� 53      -   5        $ lblRoomType_Copy��53      $ ��Номер комнаты:��6.   $��Center=�6G   $
��Left=�6k   $��Center=�6�   $��16(�6�   $	��127��6�   $ 82��6�   $		 204��6�   $ 0.535,0.801&�6�   �� 54      -   5        $ cmbRoomNumber��54      $��Center=�6.   $	��Top=�6K   $	��120��6c   $	 245��6o   $		 208��6�   $��16(�6�   $��26��6�   �� 55      -   5        $ btnCheck��55      $:��4Посмотреть предыдущий номер��6'   $
��Left=�6M   $��Center=�6h   $	��292��6�   $��32��6�   ���#4682B4$��18(�6�   ���	#FFF1F1F1$ 86��6�   $		 159��6�   6�   �� 56      -   5        $ lblEmployeeID��56      $��ID работника:��6+   $y�Hidden=�6C   $��Center=�6W   $
��Left=�6{   $��Center=�6�   $��16(�6�   $	 106��6�   �� 57      -   5        $
 txtEmployeeID��57      $
��Left=�6-   $y�Hidden=�6H   $��31��6\   $
 Wrap=�6h   $��E00001��6|   $	��Top=�6�   $	��283��6�   $��18(�6�   $	 256��6�   $	 1��6�   {�.  6�   �� 58      -   5        $ 
lblMessage��58      $�� ��6(   $��Center=�63   $
��Left=�6W   $	��Top=�6r   $��16(�6�   $	��319��6�   $		 170��6�   $	 412��6�   
���  ��6�   59      �� 5:   
   -    5        $ 
lblGuestID��5:      $��Номер гостя:��6$   $��Center=�6<   $��Right=�6`   $��0,248,523,0q�6|   $	��Top=�6�   $��16(�6�   $��1��6�   �� 5;   
   -!   5        $
 
txtGuestID��5;      $��Right=�6&   $��31��6B   $��0,249,315,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��134��6�   $��18(�6�   $��1��6�   	� 5<   
   -"   5         	�Name$ rdbExistingGuest��5<      $)��#Существующий гость��60   $
��Left=�6M   $��
69,206,0,0q�6h   $	��Top=�6|   $��37��6�   $	��211��6�   $��16(�6�   $��1��6�   	� 5=   
   -#   5        $ rdbNewGuest��5=      $��Новый гость��6+   $
��Left=�6A   $��263,206,0,0q�6\   $	��Top=�6q   $��37��6�   $	��126��6�   $��16(�6�   $��1��6�   �� 5>   
   -$   5        $ btnGuest��5>      $��База гостей��6#   $��Right=�69   $	��Top=�6U   $	��110��6m   $��32��6y   ���#4682B4$��18(�6�   ���	#FFF1F1F1$ -0.409,0.626&�6�   $��1��6�   $��0,249,184,0q�6  5@      5A      