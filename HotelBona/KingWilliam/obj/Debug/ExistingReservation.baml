   M S B A M L   `   `   `  ����F  BKingWilliam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KingWilliamKingWilliam  5   	   %    KingWilliam.ExistingReservation   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:KingWilliam     5   	     � Title$  ExistingReservation��5   	   $��854.654��6%   $
��1118��66    � 
ResizeMode$ CanMinimize=�6C    � WindowState$ Normal=�6\   .��5	      � $	��805��6   $	��Top=�6   $
��Left=�60   $
��1226��6K   .+�5
   
   �� $��0 0 0 1q�6   ���	#FF3556C8$
��Left=�6D   $	��119��6_   $	��Top=�6l   $
��1534��6�   $��3��6�   ._�5      �� -   5         ��Name$ image��5      $��/logo_site.png��6#    J� RenderTransformOrigin$ -0.491,-0.017&�6;   $��171,-68,1090,-47q�6a   5      �� 5   
   -   5         ��Name$! lblExistingReservationTitle��5      $��Бронирование��65   $
��Left=�6L   $��162,119,0,0q�6g   $	��Top=�6|   $��48(�6�   $
��Bold"�6�   $��Times New Roman)�6�   �� 5   
   -   5        $ label2��5      $��Введите номер��6    $
��Left=�68   $��203,203,0,0q�6S   $	��Top=�6h   $��26(�6�   $	��388��6�   �� 5   
   -   5         ��Name$ txtFind��5      $
��Left=�6#   $��32��6>   $��502,209,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   $��16(�6�   �� 5   
   -   5         ��Name$ btnFind��5      $��
Найти��6"   $
��Left=�62   $��214,269,0,0q�6M   $	��Top=�6b   $��99��6z   ���#4682B4$��16(�6�   ���	#FFF1F1F1$��34��6�   6�   �� 5   
   -   5        $��	cnvResult��5   B   $��290,315,292.2,77.2q�6   $y�Visible=�6-   .+�5      �� -   5        $ lblGuestFirstName��5      $��Имя:��6/   $��Center=�6?   $
��Left=�6c   $��Center=�6~   $��16(�6�   	 �� Left$		 -61��6�   

 �� Top$
 59��6�   $ -0.666,0.577&�6�   �� 5      -   5        $ lblPhone��5      $��Телефон:��6&   $��Center=�69   $
��Left=�6]   $��Center=�6x   $��16(�6�   $	��101��6�   $	
 137��6�   $		 -73��6�   �� 5      -	   5        $ lblEmail��5      $��E-mail:��6&   $��Center=�69   $
��Left=�6]   $��Center=�6x   $��16(�6�   $	��101��6�   $		 323��6�   $	
 137��6�   �� 5      -
   5        $ 
lblAddress��5      $"��Номер паспорта:��6(   $��Center=�6C   $
��Left=�6g   $��Center=�6�   $��16(�6�   $	��101��6�   $
 98��6�   $		 -82��6�   �� 5      -   5        $ txtFirstName��5      $
��Left=�6,   $��31��6G   $
 Wrap=�6S   $�� ��6g   $��Center=�6o   $	��283��6�   $	 45��6�   $
 59��6�   $��16(�6�   �� 5      -   5        $ txtPhone��5      $
��Left=�6(   $��31��6C   $
 Wrap=�6O   $�� ��6c   $��Center=�6k   $	��283��6�   $	 45��6�   $	
 143��6�   $��16(�6�   �� 5      -   5        $ 
txtAddress��5      $
��Left=�6*   $��31��6E   $
 Wrap=�6Q   $�� ��6e   $��Center=�6m   $	��283��6�   $	 45��6�   $	
 101��6�   $��16(�6�   �� 5      -   5        $ txtEmail��5      $
��Left=�6(   $��31��6C   $
 Wrap=�6O   $�� ��6c   $��Center=�6k   $	��283��6�   $		 462��6�   $	
 143��6�   $��16(�6�   �� 5      -   5        $ lblGuestLastName��5      $��Фамилия:��6.   $��Center=�6B   $
��Left=�6f   $��Center=�6�   $��16(�6�   $		 348��6�   $
 59��6�   �� 5      -   5        $ txtLastName��5      $
��Left=�6+   $��31��6F   $
 Wrap=�6R   $�� ��6f   $��Center=�6n   $	��284��6�   $		 462��6�   $
 59��6�   $��16(�6�   �� 5      -   5        $ lblPostalCode��5      $��Пол:��6+   $��Center=�6;   $
��Left=�6_   $��Center=�6z   $��16(�6�   $	��101��6�   $		 331��6�   $
 98��6�   �� 5      -   5        $ txtPostalCode��5      $
��Left=�6-   $��31��6H   $
 Wrap=�6T   $�� ��6h   $��Center=�6p   $	��283��6�   $		 462��6�   $	
 101��6�   $��16(�6�   �� 5      $	��168��6   $		 195��6"   $	
 211��64   $	��585��6E   $��2q�6R   ._�5      � $��-298,-8,299,8q�6   .+�5       �� -   5        $ lblStartDateDisplay��5       $��Дата заезда:��69   $��Center=�6P   $
��Left=�6t   $	��Top=�6�   $��16(�6�   $	��178��6�   $��	-4,10,0,0q�6�   �� 5!      -   5        $ lblEndDateDisplay��5!      $��Дата отъезда:��67   $��Center=�6O   $
��Left=�6s   $	��Top=�6�   $��16(�6�   $	��181��6�   $��	-2,57,0,0q�6�   �� 5"      -   5        $ lblRoomNumber��5"      $�� ��63   $��Center=�6>   $
��Left=�6b   $	��Top=�6}   $��16(�6�   $	��174��6�   
���   �$��197,108,0,0q�6�   
���   �$��1q�6�   $��36��6�   �� 5#      -   5        $ lblRoomNumberDisplay��5#      $ ��Номер комнаты:��6:   $��Center=�6S   $
��Left=�6w   $	��Top=�6�   $��16(�6�   $	��129��6�   $��
34,108,0,0q�6�   �� 5$      -   5        $ lblStartDate��5$      $�� ��62   $��Center=�6=   $
��Left=�6a   $	��Top=�6|   $��16(�6�   $	��174��6�   
���   �$��
197,10,0,0q�6�   
���   �$��1q�6�   $��36��6�   �� 5%      -   5        $ 
lblEndDate��5%      $�� ��60   $��Center=�6;   $
��Left=�6_   $	��Top=�6z   $��16(�6�   $	��174��6�   
���   �$��
197,57,0,0q�6�   
���   �$��1q�6�   $��36��6�   5&      5'      �� 5(      -   5        $ 	btnUpdate��5(      $��Сохранить��6(   $
��Left=�6<   $��Center=�6W   $	��159��6r   $��48��6~   ���#4682B4$��18(�6�   ���	#FFF1F1F1$		 273��6�   $	
 413��6�   6�   �� 5)      -   5        $ 	btnDelete��5)      $-��'Удалить бронирование��6(   $
��Left=�6G   $��Center=�6b   $	��218��6}   $��48��6�   ���#4682B4$��18(�6�   ���	#FFF1F1F1$		 495��6�   $	
 413��6�   6�   �� 5*      -   5        $ 
lblGuestID��5*      $��ID гостя:��6(   $��Center=�6=   $
��Left=�6a   $��Center=�6|   $��16(�6�   $		 -65��6�   $
 9��6�   �� 5+      -   5        $ 
txtGuestID��5+      $
��Left=�6*   $��31��6E   $
 Wrap=�6Q   $�� ��6e   $��Center=�6m   $	��283��6�   $��16(�6�   $	 45��6�   $
 10��6�   {�.  6�   5,      �� 5-   
   -   5        $ 	btnCancel��5-      $��
Назад��6$   $
��Left=�64   $	��Top=�6O   $	��120��6g   $��34��6s   ���#4682B4$��16(�6�   ���	#FFF1F1F1$��400,269,0,0q�6�   �� 5.   
   -   5        $ btnEdit��5.      $5��/Изменить дату или комнату��6"   $
��Left=�6F   $	��Top=�6a   $	��267��6y   $��48��6�   ���#4682B4$��18(�6�   ���	#FFF1F1F1$��219,728,0,0q�6�   6�   50      51      